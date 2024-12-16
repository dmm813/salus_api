using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Salus_Core.Dominio;

namespace Salus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult Create(Usuario usuario)
        {
            return Created();
        }
    }
}
