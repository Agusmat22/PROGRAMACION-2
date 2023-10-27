using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interfaces;

namespace Entidades
{
    public class Contrato : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un contrato");
        }
    }
}
