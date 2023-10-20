using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Excepciones;

namespace Entidades
{
    public class MiClase
    {
        
        public MiClase() 
        {
            try
            {
                MiClase miClase = new MiClase(10);
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Excepcion capturada en el ctor con parametros y re lanzada MI CLASE", ex);
            }
            
        }
        public MiClase(int id) 
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                throw;
            }

        }

        public static void MetodoEstatico()
        {
            //Con throw enviamos una excepcion NUNCA CON RETURN
            throw new DivideByZeroException("Excepcion de mi clase DivideByZero");
        }
        

    }
}
