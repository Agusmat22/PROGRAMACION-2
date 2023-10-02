using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private double altura_y;
        private double base_x;
        public Rectangulo(double altura_y,double base_x) :base()
        { 
            this.altura_y = altura_y;
            this.base_x = base_x;   
        }

        public double Altura
        {
            get
            {
                return this.altura_y;
            }
        }

        public double Base
        {
            get
            {
                return this.base_x;
            }
        }


        public override double CalcularSuperficie()
        {
            return Altura * Base;
        }

        public override double CalcularPerimetro()
        {
            return (Altura * 2) + (Base * 2);
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo...";
        }
    }
}
