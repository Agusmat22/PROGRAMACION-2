using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Centralita.Interfaces;

namespace Centralita
{
    public class Provincial : Llamada, IGuardar<Provincial>
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
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        public string RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



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

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Provincial llamada)
            {
                return this == llamada;
            }

            return false;
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public bool Guardar()
        {
            if (File.Exists(this.RutaDeArchivo))
            {
                Llamada.Serializar(this, this.RutaDeArchivo);
            }

            return false;
        }

        public Provincial Leer()
        {
            Provincial llamada;

            if (File.Exists(this.RutaDeArchivo))
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(this.RutaDeArchivo))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Provincial));

                        llamada = xmlSerializer.Deserialize(streamReader) as Provincial;

                        return llamada;

                    }

                }
                catch(InvalidOperationException ex)
                {
                    throw ex;
                }

                
            }

            return null;
        }
    }
}
