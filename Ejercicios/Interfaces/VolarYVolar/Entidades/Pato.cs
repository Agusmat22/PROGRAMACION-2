using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pato : IVoladores
    {
        private int cantidadDeEnergia;

        public Pato(int cantidadDeEnergia)
        {
            this.cantidadDeEnergia = cantidadDeEnergia;
        }

        public void Volador()
        {
            this.cantidadDeEnergia -= 5;
            Console.WriteLine($"Estoy volando como un pato !Cuak!, tengo {this.cantidadDeEnergia} energia");
        }
    }
}
