using Microsoft.AspNetCore.Identity;

namespace Usuarios.Models
{
    public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public Usuario() : base() { }
    }
}