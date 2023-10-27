using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BuzzLightyear : IVoladores
    {
        public int experiencia;

        public BuzzLightyear(int experiencia)
        {
            this.experiencia = experiencia;
        }

        public void Volador()
        {
            this.experiencia += 3;
            Console.WriteLine($"Al infinito y mas alla, tengo {this.experiencia} experiencia");
        }
    }
}
