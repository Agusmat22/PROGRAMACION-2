using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validador
    {

        public static bool ValidarString(string cadena)
        {
            return string.IsNullOrEmpty(cadena);
        }

        public static bool ParsearNumero(string numero,out int numeroParseado)
        {
            return int.TryParse(numero, out numeroParseado);
        }

        public static bool ParsearNumero(string numero, out double numeroParseado)
        {
            return double.TryParse(numero, out numeroParseado);
        }
    }
}
