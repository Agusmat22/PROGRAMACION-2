using IO.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoXml<T> : Archivo, IArchivo<T> where T : class
    {   
        protected override string Extension
        {
            get { return ".xml"; }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (this.ValidarSiExisteElArchivo(ruta) && this.ValidarExtension(ruta))
            {
               this.SerializarXml(ruta, contenido); 
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (this.ValidarExtension(ruta))
            {
                this.SerializarXml(ruta, contenido,true);
            }
        }

        public T Leer(string ruta)
        {
            if (this.ValidarSiExisteElArchivo(ruta))
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(ruta))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                        string archivoLeido = streamReader.ReadToEnd();

                        T archivoDeserializado = xmlSerializer.Deserialize(streamReader) as T;

                        return archivoDeserializado;

                    }
                }
                catch (Exception ex) 
                {
                    throw ex;
                }
                
            }

            return null;

        }

        private void SerializarXml(string ruta, T contenido)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    xmlSerializer.Serialize(streamWriter, contenido);
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            
        }

        private void SerializarXml(string ruta, T contenido,bool apendear)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta, apendear))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    xmlSerializer.Serialize(streamWriter, contenido);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
