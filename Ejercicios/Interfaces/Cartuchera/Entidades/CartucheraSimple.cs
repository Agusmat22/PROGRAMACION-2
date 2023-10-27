using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraSimple
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;

        public CartucheraSimple(List<Boligrafo> boligrafos, List<Lapiz> lapices)
        {
            this.boligrafos = boligrafos;
            this.lapices = lapices;
        }

       
    }
}
