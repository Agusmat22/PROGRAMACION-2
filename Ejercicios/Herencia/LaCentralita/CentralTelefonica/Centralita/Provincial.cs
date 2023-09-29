using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        public enum Franja //Los enum reciben solo integer
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(string origen, Franja franjaHoraria , float duracion, string destino ) 
            : base(duracion,destino,origen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public Provincial(Franja franjaHoraria, Llamada llamada) 
            : this(llamada.NroOrigen,franjaHoraria, llamada.Duracion,llamada.NroDestino)
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


        //METHOD
        private float CalcularCosto()
        {
            float costo;

            if (this.franjaHoraria == Provincial.Franja.Franja_1)
            {
                costo = 0.99F;
            }
            else if(this.franjaHoraria == Provincial.Franja.Franja_2)
            {
                costo = 1.25F;
            }
            else
            {
                costo = 0.66F;
            }

            return this.Duracion * costo;
        }
    }
}
