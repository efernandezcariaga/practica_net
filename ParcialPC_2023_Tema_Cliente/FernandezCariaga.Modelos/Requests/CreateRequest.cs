using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezCariaga.Modelos.Requests
{
    public class CreateRequest
    {
        public string CodigoCliente { get; set; }
        public string Email { get; set; }
        public int NivelCliente { get; set; }
        public string RazonSocial { get; set; }
        public DateTime? UltimaCompraRealizada { get; set; }
    }
}
