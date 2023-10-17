using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        
        public void MiMetodoDeInstacia()
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Excepcion capturada en el ctor con parametros y re lanzada en OTRA CLASE", ex);
            }
        }

    }
}
