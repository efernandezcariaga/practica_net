using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezCariaga.Escritorio
{
    public class Validaciones
    {
        public static bool CamposRequeridos(string clave, string nomUsu, string email, string tipUsu)
        {
            if (String.IsNullOrEmpty(clave))
            {
                throw new Exception("Debe ingresar una clave");
            }
            if (clave.Length < 4)
            {
                throw new Exception("La clave debe ser mayor a 4 caracteres");
            }
            if (String.IsNullOrEmpty(nomUsu))
            {
                throw new Exception("Debe ingresar un nombre de usuario");
            }
            if (nomUsu.Length < 8)
            {
                throw new Exception("El nombre de usuario debe ser mayor a 4 caracteres");
            }
            if (String.IsNullOrEmpty(email))
            {
                throw new Exception("Debe ingresar un email");
            }
            if (String.IsNullOrEmpty(tipUsu))
            {
                throw new Exception("Debe ingresar un tipo de usuario");
            }
            try
            {
                Convert.ToInt32(tipUsu);
            }
            catch
            {
                throw new Exception("El tipo de usuario debe ser un numero entero");
            }

            return true;
        }
    }
}
