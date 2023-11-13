using Microsoft.AspNetCore.Mvc;
using Usuarios.Data.Dto;
using Usuarios.Services;

namespace Usuarios.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private CadastroService _cadastroService;

        public UsuariosController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            await _cadastroService.Cadastra(dto);
            return Ok("Usuário cadastrado!");
        }
    }
}