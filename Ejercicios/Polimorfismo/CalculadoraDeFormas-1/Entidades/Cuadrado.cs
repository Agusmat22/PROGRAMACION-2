using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuadrado : Rectangulo
    {
        
        public Cuadrado(double altura_y,double base_x):base(altura_y,base_x)
        {

        }

        public override double CalcularSuperficie()
        {
            return Math.Pow(this.Altura, 2);
        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }
    }
}
