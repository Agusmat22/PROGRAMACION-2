using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero,string escuderia) :base(escuderia,numero)
        {
           
        }

        public MotoCross(short numero, string escuderia, short cilindrada):this(numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get
            {
                return cilindrada;
            }

            set
            {
                cilindrada = value;
            }
        }

        public static bool operator ==(MotoCross m1,MotoCross m2)
        {
            return m1.cilindrada == m2.cilindrada;
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
