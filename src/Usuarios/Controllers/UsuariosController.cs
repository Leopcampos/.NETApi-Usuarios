using Microsoft.AspNetCore.Mvc;
using Usuarios.Data.Dto;

namespace Usuarios.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto dto)
        {
            throw new NotImplementedException();
        }
    }
}