using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Salus_Core.Dominio;
using Salus_Application;

namespace Salus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        ApplicationUsuario cUser = new ApplicationUsuario(); 

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult Create(Usuario usuario)
        {
            cUser.Insert(usuario);
            return Created();
        }
    }
}
