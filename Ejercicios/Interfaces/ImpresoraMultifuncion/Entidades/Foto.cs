﻿using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Foto : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy una foto");
        }
    }
}
