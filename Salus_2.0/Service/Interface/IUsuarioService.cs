using Salus_2._0.Models;

namespace Salus_2._0.Service.Interface
{
    public interface IUsuarioService
    {
        Task<BaseDataResponse<List<UsuarioModel>>> GetAllAsync();
        Task<BaseDataResponse<UsuarioModel>> GetAsync(int id);
        Task<BaseResponse> SetAsync(UsuarioModel user);
        Task<BaseResponse> PutAsync(UsuarioModel user);
        Task<BaseResponse> DelAsync(int id);
    }
}
