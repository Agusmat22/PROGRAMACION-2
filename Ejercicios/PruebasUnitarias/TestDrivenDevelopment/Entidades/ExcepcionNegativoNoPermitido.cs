using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionNegativoNoPermitido : Exception
    {

        public ExcepcionNegativoNoPermitido(string mensaje) :base(mensaje) 
        { 
        }

        public ExcepcionNegativoNoPermitido(string mensaje, Exception ex) : base(mensaje, ex)
        {
        }
    }
}
