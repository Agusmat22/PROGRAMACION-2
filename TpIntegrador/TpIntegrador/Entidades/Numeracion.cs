using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Enumerado con el tipo de sistema.
    public enum ESistema
    {
        Decimal,
        Binario
    }

    public class Numeracion
    {
        private ESistema ESistema;
        private double valorNumerico;

        public Numeracion()
        {

        }

        //GETTER
        public ESistema GetSistema()
        { return ESistema; }

        public double GetValorNumerico()
        { return valorNumerico; }

    }
}
