using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Salus_2._0.DTO;
using Salus_2._0.Service.Interface;

namespace Salus_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;
        public AuthController(IAuthService auth) {
            _auth = auth;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterDTO register)
        {
            return Ok(await _auth.Registrar(register));
        }

        [HttpPost("login")]
        public async Task<ActionResult> Register(LoginDTO user)
        {
            return Ok(await _auth.Login(user));
        }
    }
}
