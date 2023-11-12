using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameGenerator.Generators;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Entidades
{
    public class Negocio
    {
        static RealNameGenerator realNameGenerator;
        public ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio()
        {
            Negocio.realNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            this.clientes = new ConcurrentQueue<string>();
        }

        public void ComenzarAtencion()
        {
            foreach (Caja item in this.cajas)
            {
                item.IniciarAtencion();
            }
        }

    
    }
}
