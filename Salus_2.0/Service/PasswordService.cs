using Microsoft.IdentityModel.Tokens;
using Salus_2._0.Models;
using Salus_2._0.Service.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Salus_2._0.Service
{
    public class PasswordService : IPasswordService
    {
        private readonly IConfiguration _config;
        public PasswordService(IConfiguration config) => _config = config;

        public void CreateHash(string senha, out byte[] senhaHash, out byte[] senhaSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                senhaSalt = hmac.Key;
                senhaHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
            }
        }

        public bool IsNotValidPassword(string senha, byte[] senhaHash, byte[] senhaSalt)
        {
            using (var hmac = new HMACSHA512(senhaSalt))
            {
                var computerHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
                return !computerHash.SequenceEqual(senhaHash);
            }
        }

        public string CreateToken(RegisterModel user)
        {
            var claims = new List<Claim>()
            {
                new("Cargo", user.Cargo.ToString()),
                new("Email", user.Email),
                new("Usuario", user.Usuario),
            };

            var tokenSecret = _config.GetSection("AppSettings:Token").Value;
            if (string.IsNullOrEmpty(tokenSecret))
            {
                throw new Exception("Token secret not found in appsettings.json");
            }

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(tokenSecret));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(8),
                signingCredentials: cred
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
