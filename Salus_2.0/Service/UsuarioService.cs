using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Salus_2._0.DataContext;
using Salus_2._0.Models;
using Salus_2._0.Service.Interface;

namespace Salus_2._0.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDBContext _context;
        public UsuarioService(AppDBContext context) => _context = context;

        public async Task<BaseResponse> DelAsync(int id)
        {
            var response = new BaseResponse();
            try
            {
                UsuarioModel? user = await _context.Usuario.FirstOrDefaultAsync(x => x.IdUsuario == id);
                if (user != null)
                {
                    _context.Usuario.Remove(user);
                    await _context.SaveChangesAsync();
                } else
                {
                    response.Mensagem = "Usuário não localizado!";
                    response.Sucesso = false;
                }
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }
            return response;
        }

        public async Task<BaseDataResponse<List<UsuarioModel>>> GetAllAsync()
        {
            var responseData = new BaseDataResponse<List<UsuarioModel>>();

            try
            {
                responseData.Dados = await _context.Usuario.ToListAsync();
                if(responseData.Dados.IsNullOrEmpty())
                {
                    responseData.Mensagem = "Nenhum dado encontrado!";
                }
            }
            catch (Exception ex)
            {
                responseData.Mensagem = ex.Message;
                responseData.Sucesso = false;
            }

            return responseData;
        }

        public async Task<BaseDataResponse<UsuarioModel>> GetAsync(int id)
        {
            var responseData = new BaseDataResponse<UsuarioModel>();
            try
            {
                responseData.Dados = await _context.Usuario.FirstOrDefaultAsync(x => x.IdUsuario == id);
                if (responseData.Dados == null)
                {
                    responseData.Mensagem = "Usuário não localizado!";
                    responseData.Sucesso = false;
                }
            }
            catch (Exception ex)
            {
                responseData.Mensagem = ex.Message;
                responseData.Sucesso = false;
            }
            return responseData;
        }

        public async Task<BaseResponse> PutAsync(UsuarioModel user)
        {
            var response = new BaseResponse();

            try
            {
                var _user = await _context.Usuario.FirstOrDefaultAsync(x => x.IdUsuario == user.IdUsuario);

                if (_user == null)
                {
                    response.Mensagem = "Usuário não localizado!";
                    response.Sucesso = false;
                }
                else
                {
                    _context.Entry(_user).CurrentValues.SetValues(user);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }
            return response;
        }

        public async Task<BaseResponse> SetAsync(UsuarioModel user)
        {
            var response = new BaseResponse();
            try
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }
            return response;
        }
    }
}
