using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interfaces;

namespace Entidades
{
    public class TorreDeControl
    {
        private List<IVoladores> voladores;

        public TorreDeControl()
        {
            this.voladores = new List<IVoladores>();
        }

        public void VuelenTodos()
        {
            foreach (IVoladores item in this.voladores)
            {
                item.Volador();
            }
        }

        public void AgregarVoladores(IVoladores volador)
        {
            this.voladores.Add(volador);
        }
    }
}
