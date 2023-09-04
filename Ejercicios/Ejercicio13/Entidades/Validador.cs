using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validador
    {

        public static bool SeleccionarOpcion(string opcion,string opcionCorrecta)
        {
            return opcion.ToLower() == opcionCorrecta.ToLower();
        }

    }
}
