using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo; //el valor por segundo de la llamada

        public Local(string origen,float duracion,string destino,float costo)
            :base(duracion,destino,origen)
        {
            this.costo = costo; 
        }

        public Local(Llamada llamada,float costo)
            :this(llamada.NroOrigen, llamada.Duracion,llamada.NroDestino,costo)
        {

        }

        //PROPERTY
        public float CostoLlamada
        {
            get 
            {
                return CalcularCosto();
            }
        }

        /// <summary>
        /// Calcula el precio de la llamada en base a la duracion y el costo del mismo
        /// </summary>
        /// <returns>Un flotante sera el resultado entre la duracion y costo</returns>
        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        /// <summary>
        /// Muestra el metodo padre y agrega el costo de la llamada
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return sb.ToString();         
        }
    }
}
