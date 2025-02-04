using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Salus_2._0.Models;
using Salus_2._0.Service.Interface;

namespace Salus_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _user;
        public UsuarioController(IUsuarioService user) => _user = user;

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<BaseDataResponse<List<UsuarioModel>>>> GetAllAsync()
        {
            return Ok(await _user.GetAllAsync());
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<BaseDataResponse<UsuarioModel>>> GetAsync(int id)
        {
            return Ok(await _user.GetAsync(id));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<BaseResponse>> SetAsync(UsuarioModel user)
        {
            return Ok(await _user.SetAsync(user));
        }

        [Authorize]
        [HttpPut]
        public async Task<ActionResult<BaseResponse>> PutAsync(UsuarioModel user)
        {
            return Ok(await _user.PutAsync(user));
        }

        //[Authorize]
        [HttpDelete]
        public async Task<ActionResult<BaseResponse>> DelAsync(int id)
        {
            return Ok(await _user.DelAsync(id));
        }
    }
}
