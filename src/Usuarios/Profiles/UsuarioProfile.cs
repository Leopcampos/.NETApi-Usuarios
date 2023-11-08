using AutoMapper;
using Usuarios.Data.Dto;
using Usuarios.Models;

namespace Usuarios.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}