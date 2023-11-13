using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Usuarios.Data.Dto;
using Usuarios.Models;

namespace Usuarios.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public CadastroService(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task Cadastra(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);

            IdentityResult resultardo = await _userManager.CreateAsync(usuario, dto.Password);

            if (!resultardo.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário!");
            }
        }
    }
}