using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Texto
    {
        private string contenido;
        private int colorARGB;

        public Texto(string contenido, int colorARGB)
        {
            Contenido = contenido;
            ColorARGB = colorARGB;
        }

        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }


        public int ColorARGB
        {
            get { return colorARGB; }
            set { colorARGB = value; }
        }

       

    }
}
