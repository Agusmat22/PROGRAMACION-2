﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum EPuesto
        {
            Caja1,
            Caja2
        }

        private static int numeroActual;
        private EPuesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get { return numeroActual + 1; }
        }

        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(1000);

                return true;

            }

            return false;
            
        }

        

    }
}
