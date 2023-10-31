using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO.Interfaz;

namespace IO
{
    public class PuntoTxt: Archivo ,IArchivo<string>
    {
        protected override string Extension
        {
            get { return ".txt"; }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (this.ValidarSiExisteElArchivo(ruta) && this.ValidarExtension(ruta))
            {
                this.GuardarArchivo(ruta, contenido);

            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            if (this.ValidarExtension(ruta))
            {
                this.GuardarArchivo(ruta, contenido);
            }
        }

        public string Leer(string ruta)
        {
            string archivoLeido = string.Empty;

            if (this.ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    archivoLeido = streamReader.ReadToEnd();
                }
            }

            return archivoLeido;
        }

        //guarda un archivo
        private void GuardarArchivo(string ruta, string contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                streamWriter.WriteLine(contenido);
            }
        }
    }
}
