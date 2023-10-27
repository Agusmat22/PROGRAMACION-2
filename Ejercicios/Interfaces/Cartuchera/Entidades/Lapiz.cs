using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina;
        }

        //IMPLEMENTO TODAS LAS PROPIEDADES Y METODOS POR CONTRATO

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return (int)this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            int cantidadDeCaracteres = texto.Length;

            tamanioMina -= cantidadDeCaracteres * 0.1F;

            return new EscrituraWrapper(this.Color, texto);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Lapiz con color de mina {this.Color} y su tamanio de mina es {this.tamanioMina}";
        }
    }
}
