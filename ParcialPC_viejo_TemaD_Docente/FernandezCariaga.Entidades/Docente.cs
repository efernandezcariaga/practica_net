namespace FernandezCariaga.Entidades
{
    public class Docente
    {
        public string ApellidoNombre { get; set; }
        public string CUIL { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Id { get; set; }
        public decimal Salario { get; set; }
        public int Antiguedad { get; set; }

        public Docente() { }

        public Docente(string apellidoNombre, string Cuil, string email, DateTime fechaIngreso, int id, decimal salario)
        {
            ApellidoNombre = apellidoNombre;
            CUIL = Cuil;
            Email = email;
            FechaIngreso = fechaIngreso;
            Id = id;
            Salario = salario;
            Antiguedad = (int)(DateTime.Now - fechaIngreso).TotalDays;
        }
    }
}