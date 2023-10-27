using Entidades.Interfaces;

namespace Entidades
{
    public class Boing747 : IVoladores
    {
        private int horasDeVuelo;

        public Boing747(int horasDeVuelo)
        {
            this.horasDeVuelo = horasDeVuelo;
        }

        public void Volador()
        {
            this.horasDeVuelo += 13;
            Console.WriteLine($"Al infinito y mas alla, tengo {this.horasDeVuelo} horas de vuelo");

        }
    }
}