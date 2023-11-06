namespace FernandezCariaga.Entidades
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string CodigoCliente { get; set; }
        public string Email { get; set; }
        public int NivelCliente { get; set; }
        public string RazonSocial { get; set; }
        public DateTime? UltimaCompraRealizada { get; set; }

        public Cliente() { }

        public Cliente(Guid id, string codigoCliente, string email, int nivelCliente, string razonSocial)
        {
            Id = id;
            CodigoCliente = codigoCliente;
            Email = email;
            NivelCliente = nivelCliente;
            RazonSocial = razonSocial;
        }
    }
}