using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Salus_2._0.Models;
using Salus_2._0.Repository;

namespace Salus_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IRepository<UsuarioModel> _user;
        public UsuarioController(IRepository<UsuarioModel> user) => _user = user;

        [Authorize]
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<BaseDataResponse<List<UsuarioModel>>>> GetAllAsync()
        {
            var baseDataResponse = new BaseDataResponse<IEnumerable<UsuarioModel>>();

            try
            {
                baseDataResponse.Dados = await _user.GetAllAsync();
            }
            catch (Exception ex)
            {
                baseDataResponse.Mensagem = ex.Message;
                baseDataResponse.Sucesso = false;
            }

            return Ok(baseDataResponse);
        }

        [Authorize]
        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ActionResult<BaseDataResponse<UsuarioModel>>> GetByIdAsync(int id)
        {
            var baseDataResponse = new BaseDataResponse<UsuarioModel>();

            try
            {
                baseDataResponse.Dados = await _user.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                baseDataResponse.Mensagem = ex.Message;
                baseDataResponse.Sucesso = false;
            }

            return Ok(baseDataResponse);
        }

        [Authorize]
        [HttpGet]
        [Route("GetByEmail/{email}")]
        public async Task<ActionResult<BaseDataResponse<UsuarioModel>>> GetByEmailAsync(string login)
        {
            var baseDataResponse = new BaseDataResponse<UsuarioModel>();

            try
            {
                baseDataResponse.Dados = await _user.FindByConditionAsync(x => x.Login == login);
            }
            catch (Exception ex)
            {
                baseDataResponse.Mensagem = ex.Message;
                baseDataResponse.Sucesso = false;
            }

            return Ok(baseDataResponse);
        }

        [Authorize]
        [HttpPost]
        [Route("Add")]

        public async Task<ActionResult<BaseResponse>> AddAsync(UsuarioModel user)
        {
            var baseResponse = new BaseResponse();

            try
            {
                _user.Add(user);
                await _user.SaveChangesAsync();
                baseResponse.Mensagem = "Registro salvo com sucesso";
            }
            catch (Exception ex)
            {
                baseResponse.Mensagem = ex.Message;
                baseResponse.Sucesso = false;
            }

            return Ok(baseResponse);
        }

        [Authorize]
        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<BaseResponse>> UpdateAsync(UsuarioModel user)
        {
            var baseResponse = new BaseResponse();

            try
            {
                _user.Update(user);
                await _user.SaveChangesAsync();
                baseResponse.Mensagem = "Registro atualizado com sucesso";
            }
            catch (Exception ex)
            {
                baseResponse.Mensagem = ex.Message;
                baseResponse.Sucesso = false;
            }

            return Ok(baseResponse);
        }

        [Authorize]
        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ActionResult<BaseResponse>> DeleteAsync(int id)
        {
            var baseResponse = new BaseResponse();

            try
            {
                await _user.Delete(id);
                await _user.SaveChangesAsync();
                baseResponse.Mensagem = "Registro deletado com sucesso";
            }
            catch (Exception ex)
            {
                baseResponse.Mensagem = ex.Message;
                baseResponse.Sucesso = false;
            }

            return Ok(baseResponse);
        }
    }
}
