using Salus_2._0.DTO;
using Salus_2._0.Models;

namespace Salus_2._0.Service.Interface
{
    public interface IAuthService
    {
        Task<BaseDataResponse<RegisterDTO>> Registrar(RegisterDTO register);
        Task<BaseDataResponse<string>> Login(LoginDTO user);
    }
}
