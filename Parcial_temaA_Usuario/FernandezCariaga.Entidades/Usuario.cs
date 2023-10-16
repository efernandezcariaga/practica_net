namespace FernandezCariaga.Entidades
{
    public class Usuario
    {
        public Guid id { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public int TipoUsuario { get; set; }
        public DateTime UltimoIngreso { get; set; }

        public int DiasUltimoIngreso
        {
            get
            {
                TimeSpan diferencia = DateTime.Now - UltimoIngreso;
                return diferencia.Days;
            }
        }

        public Usuario()
        {
            UltimoIngreso = DateTime.Now;
        }

        public Usuario(string clave, string email, string nombreUsuario, int tipoUsuario)
        {
            Clave = clave;
            Email = email;
            NombreUsuario = nombreUsuario;
            TipoUsuario = tipoUsuario;
            UltimoIngreso = DateTime.Now;
        }
    }
}
