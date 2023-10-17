using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExcepcionUltima : Exception
    {
        public ExcepcionUltima(string mensaje) : base(mensaje)
        {

        }

        public ExcepcionUltima(string mensaje, Exception excepcion) : base(mensaje, excepcion)
        {

        }
    }
}
