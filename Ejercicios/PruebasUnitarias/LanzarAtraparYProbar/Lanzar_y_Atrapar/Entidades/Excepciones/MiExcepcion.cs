using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class MiExcepcion :Exception
    {
        /// <summary>
        /// Llama al constructor base y lo inicializa solo con el mensaje de la expcecion pero,
        /// la excepcion se inicializa en null ya que no la recibe por parametro
        /// </summary>
        /// <param name="message"></param>
        public MiExcepcion(string message) : base(message) 
        { 
        
        }

        /// <summary>
        /// En este caso la excepcion de la clase base exception se inicializa ya que le pasamos
        /// por parametros la excepcion
        /// </summary>
        /// <param name="message"></param>
        /// <param name="excepcion"></param>
        public MiExcepcion(string message, Exception excepcion) : base(message,excepcion)
        {

        }
    }
}
