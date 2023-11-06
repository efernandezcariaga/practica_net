using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezCariaga.Escritorio
{
    public class Validaciones
    {
        public static bool CamposRequeridos(string codigoCliente, string email, string nivelCliente, string razonSocial)
        {
            //string lvlCliente = nivelCliente.ToString();
            if (string.IsNullOrEmpty(codigoCliente)) { throw new Exception("Debe ingresar un codigo de cliente"); }
            if (string.IsNullOrEmpty(email)) { throw new Exception("Debe ingresar un mail"); }
            //if (string.IsNullOrEmpty(lvlCliente)) { throw new Exception("Debe ingresar un nivel de cliente"); }


            if (string.IsNullOrEmpty(nivelCliente)) { throw new Exception("Debe ingresar un nivel de cliente"); }
            if (!Int32.TryParse(nivelCliente, out _)) { throw new Exception("No es un numero valido a convertir."); }


            if (string.IsNullOrEmpty(razonSocial)) { throw new Exception("Debe ingresar una razon social"); }
            if (codigoCliente.Length < 4) { throw new Exception("El codigo del cliente debe tener al menos 4 caracteres"); }
            if (razonSocial.Length < 8) { throw new Exception("La razon social debe tener al menos 8 caracteres"); }
            return true;
        }
    }
}
