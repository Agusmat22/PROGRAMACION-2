using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class CentralitaException :Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CentralitaException(string mensaje):base(mensaje)
        {

        }

        public CentralitaException(string mensaje,Exception ex) : base(mensaje,ex)
        {

        }

        public string NombreClase
        {
            get { return this.nombreClase; }
        }

        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
        }


    }
}
