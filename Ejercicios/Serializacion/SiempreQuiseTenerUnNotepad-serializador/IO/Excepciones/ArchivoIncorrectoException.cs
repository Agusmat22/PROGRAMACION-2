﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Excepciones
{
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(string mensaje) :base(mensaje) 
        { 
        
        }

        public ArchivoIncorrectoException(string mensaje, Exception ex) : base(mensaje, ex)
        {

        }
    }
}
