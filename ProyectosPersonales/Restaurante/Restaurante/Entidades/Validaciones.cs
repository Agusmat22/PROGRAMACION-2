using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public static class Validaciones
    {
        
        


        /// <summary>
        /// Valida que sea una cadena unicamente de caracteres
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns></returns>
        public static bool ValidarCaracteres(string palabra)
        { 
            return Regex.IsMatch(palabra,"^[a-zA-Z]+$");
        }

        /// <summary>
        /// Valida que sea un digito numerico
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns></returns>
        public static bool ValidarDigitos(string palabra)
        {
            bool estado = true;
            foreach (char c in palabra)
            {
                if (!char.IsDigit(c))
                {
                    estado = false;
                    break;
                }

            }

            return estado;
        }
    }
}
