using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos() 
        { 
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();

        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete item in paquetes)
            {
                this.RegistrarImpuestos(item);
            }
        }

        public void RegistrarImpuestos(Paquete paquetes)
        {
            impuestosAduana.Add(paquetes);

            if (paquetes is IAfip)
            {
                this.impuestosAfip.Add((IAfip)paquetes);
            }
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal total = 0;  
            foreach(IAduana impuesto in this.impuestosAduana)
            {
                total += impuesto.Impuestos;
            }

            return total;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal total = 0;
            foreach (IAfip impuesto in this.impuestosAfip)
            {
                total += impuesto.Impuestos;
            }

            return total;
        }
    }
}
