using Salus_2._0.Models;

namespace Salus_2._0.Service.Interface
{
    public interface IPasswordService
    {
        void CreateHash(string senha, out byte[] senhaHash, out byte[] senhaSalt);
        bool IsNotValidPassword(string senha, byte[] senhaHash, byte[] senhaSalt);
        string CreateToken(RegisterModel user);
    }
}
