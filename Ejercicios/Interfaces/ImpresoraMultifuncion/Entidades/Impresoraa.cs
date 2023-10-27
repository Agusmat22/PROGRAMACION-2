using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Impresoraa
    {
        private List<IImprimible> colaDeImpresion;

        public Impresoraa()
        {
            this.colaDeImpresion = new List<IImprimible>();
        }

        public void ImprimirTodo()
        {
            foreach (IImprimible item in colaDeImpresion)
            {
                item.Imprimir();
            }
        }

        public void AgregarImprimible(IImprimible imprimible)
        {
            colaDeImpresion.Add(imprimible);
        }
    }
}
