using System.Text;

namespace Entidades
{
    public abstract class Figura
    {

        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }

        public Figura()
        {

        }

        public double Superficie 
        {
            get
            {
                return CalcularSuperficie();
            }     
        }

        public double Perimetro
        {
            get
            {
                return CalcularPerimetro();
            }
        }

        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo: {this.GetType()}");
            sb.AppendLine($"{this.Dibujar()}");
            sb.AppendLine($"Area: {this.CalcularSuperficie()}");
            sb.AppendLine($"Perimetro: {this.CalcularPerimetro()}");

            return sb.ToString();   
        }
    }
}