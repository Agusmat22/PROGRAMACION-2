using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje,string nombreClase, string nombreMetodo):base(mensaje)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo,Exception ex)
            :base(mensaje,ex)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }

        public string NombreClase
        {
            get { return this.nombreClase; }
        }
        
        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Excepción en el método {this.NombreMetodo} de la clase {this.NombreClase}:");

            //paso la clase derivada a la padre
            Exception inner = this;

            //pregunto que contenga al menos una excepcion
            while (inner != null)
            {
                //muestra en forma de STACK 
                sb.AppendLine($"\t{inner.Message}");
                //guardo por si genero otra excepcion
                inner = inner.InnerException;

                
            }

            return  sb.ToString();
        }
    }
}
