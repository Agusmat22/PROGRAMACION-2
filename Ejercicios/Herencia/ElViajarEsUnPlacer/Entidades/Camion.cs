﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }

    }
}
