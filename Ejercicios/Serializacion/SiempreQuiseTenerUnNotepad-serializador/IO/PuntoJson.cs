using IO.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoJson<T> : Archivo,IArchivo<T> where T : class
    {
        protected override string Extension
        {
            get { return ".json"; }
        }

        public void Guardar(string ruta, T contenido)
        {
            //valid que existe el archivo y que su extensio sea del mismo tipo que la clase
            if (this.ValidarSiExisteElArchivo(ruta) && this.ValidarExtension(ruta))
            {
               this.SerializarJson(ruta, contenido);              
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (this.ValidarExtension(ruta))
            {
                this.SerializarJson(ruta, contenido);
            }
        }

        public T Leer(string ruta)
        {
            if (this.ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    string archivoLeido = streamReader.ReadToEnd();
                    T archivoDeserializado = JsonSerializer.Deserialize<T>(archivoLeido);

                    return archivoDeserializado;
                }
            }

            return null;
        }

        private void SerializarJson(string ruta, T contenido)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta, true))
                {
                    string contenidoSerializado = JsonSerializer.Serialize(contenido);
                    streamWriter.WriteLine(contenidoSerializado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
