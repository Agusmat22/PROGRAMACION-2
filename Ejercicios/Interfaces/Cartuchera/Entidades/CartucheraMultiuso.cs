using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> unidades;

        public CartucheraMultiuso(List<IAcciones> unidades)
        {
            this.unidades = unidades;
        }

        public bool RecorrerElementos()
        {
            foreach (IAcciones item in this.unidades)
            {
                if (item.UnidadesDeEscritura <= 0)
                {
                    item.Recargar(20);
                }

                item.UnidadesDeEscritura -= 1;


            }
            return true;
              
        }
    }
}
