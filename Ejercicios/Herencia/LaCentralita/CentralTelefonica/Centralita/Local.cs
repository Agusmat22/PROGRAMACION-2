using Centralita.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centralita.Interfaces;
using System.Xml.Serialization;

namespace Centralita
{
    public class Local : Llamada, IGuardar<Local>
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
        
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
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
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return sb.ToString();         
        }

        public override bool Equals(object? obj)
        {
            if (obj is Local llamada)
            {
                return this == llamada;
            }

            return false;
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public string RutaDeArchivo
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();

        }
        public bool Guardar()
        {
            if (File.Exists(this.RutaDeArchivo))
            {
                Llamada.Serializar(this, this.RutaDeArchivo);
            }

            return false;
        }

        public Local Leer()
        {
            Local llamada;

            if (File.Exists(this.RutaDeArchivo))
            {
                //valido la extension
                if (Path.GetExtension(RutaDeArchivo).ToLower() == ".xml")
                {
                    try
                    {
                        using (StreamReader streamReader = new StreamReader(this.RutaDeArchivo))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Local));

                            llamada = xmlSerializer.Deserialize(streamReader) as Local;

                            return llamada;
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw new InvalidCastException("No se pudo leer el archivo, ya que la extension es distinta de XML");
                }


            }

            return null;
        }


    }
}
