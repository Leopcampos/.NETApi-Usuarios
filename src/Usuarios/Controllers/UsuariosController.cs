using Microsoft.AspNetCore.Mvc;
using Usuarios.Data.Dto;
using Usuarios.Services;

namespace Usuarios.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuariosController(UsuarioService cadastroService)
        {
            _usuarioService = cadastroService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            await _usuarioService.Cadastra(dto);
            return Ok("Usuário cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            var token = await _usuarioService.Login(dto);
            return Ok(token);
        }
    }
}