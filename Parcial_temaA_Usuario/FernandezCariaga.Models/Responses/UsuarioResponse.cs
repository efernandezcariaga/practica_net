using System;
namespace FernandezCariaga.Models.Responses
{
	public class UsuarioResponse
	{
        public Guid id { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public int TipoUsuario { get; set; }
        public DateTime UltimoIngreso { get; set; }
    }
}

