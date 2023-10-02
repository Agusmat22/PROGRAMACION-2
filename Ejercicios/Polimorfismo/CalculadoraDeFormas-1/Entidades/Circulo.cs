using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Circulo : Figura
    {
        private short radio;
        public Circulo(short radio) : base()
        {
            this.radio = radio;
        }

        public double Diametro
        {
            get
            {
                return 2 * radio;
            }
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(radio,2);
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * Diametro;
        }

        public override string Dibujar()
        {
            return "Dibujando Circulo...";
        }
    }
}
