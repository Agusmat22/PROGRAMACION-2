using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita.Excepciones
{
    public class FallaLogException : Exception
    {

        public FallaLogException(string mensaje) : base(mensaje) 
        { 
        
        
        }

        public FallaLogException(string mensaje,Exception ex) : base(mensaje, ex)
        {


        }
    }
}
