using Microsoft.EntityFrameworkCore;
using Salus_2._0.DataContext;
using Salus_2._0.DTO;
using Salus_2._0.Models;
using Salus_2._0.Service.Interface;

namespace Salus_2._0.Service
{
    public class AuthService : IAuthService
    {
        private readonly AppDBContext _context;
        private readonly IPasswordService _passwordService;
        public AuthService(AppDBContext context, IPasswordService passwordService) {
            _context = context;
            _passwordService = passwordService;
        }
        public async Task<BaseDataResponse<RegisterDTO>> Registrar(RegisterDTO register)
        {
            var responseData = new BaseDataResponse<RegisterDTO>();
            try
            {
                if(userExist(register))
                {
                    responseData.Sucesso = false;
                    responseData.Mensagem = "Usuário já cadastrado";
                    return responseData;
                }

                _passwordService.CreateHash(register.Senha, out byte[] senhaHash, out byte[] senhaSalt);

                var user = new RegisterModel()
                {
                    Usuario = register.Usuario,
                    Email = register.Email,
                    Cargo = register.Cargo,
                    SenhaHash = senhaHash,
                    SenhaSalt = senhaSalt
                };

                _context.Add(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                responseData.Mensagem = ex.Message;
                responseData.Sucesso = false;
            }

            responseData.Mensagem = "Usuário criado com sucesso";
            return responseData;
        }

        public async Task<BaseDataResponse<string>> Login(LoginDTO user)
        {
            var responseData = new BaseDataResponse<string>();
            try
            {
                var register = await _context.Register.FirstOrDefaultAsync(u => u.Email == user.Email);

                if (register == null)
                {
                    responseData.Mensagem = "Credenciais inválidas!";
                    responseData.Sucesso = false;
                    return responseData;
                }

                if (_passwordService.IsNotValidPassword(user.Senha, register.SenhaHash, register.SenhaSalt))
                {
                    responseData.Mensagem = "Credenciais inválidas!";
                    responseData.Sucesso = false;
                    return responseData;
                }

                var token = _passwordService.CreateToken(register);
                
                responseData.Dados = token;
                responseData.Mensagem = "Usuário logado com sucesso!";

            }
            catch (Exception ex)
            {
                responseData.Mensagem = ex.Message;
                responseData.Sucesso = false;
            }
            return responseData;
        }

        public bool userExist(RegisterDTO register)
        {
            var user = _context.Register.FirstOrDefault(u => u.Email == register.Email || u.Usuario == register.Usuario);
            return user != null;
        }
    }
}
