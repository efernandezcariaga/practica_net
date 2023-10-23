using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezCariaga.Escritorio
{
    public class Validaciones
    {
        public static bool ValidacionCuil(string cuil)
        {
            string subcadena = cuil.Substring(0, 2);
            if (string.IsNullOrEmpty(cuil)) { throw new Exception("Debe ingresar un CUIL"); }
            if (cuil.Length < 11 && cuil.Length > 11) { throw new Exception("El CUIL debe tener 11 digitos"); }
            if (subcadena != "20" || subcadena != "27" || subcadena != "30") { throw new Exception("Ingrese un CUIL valido"); }
            return true;
        }
    }
}
