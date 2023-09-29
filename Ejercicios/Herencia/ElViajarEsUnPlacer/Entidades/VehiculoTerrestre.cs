using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        public enum EColores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }

        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected EColores color;
        protected short cantidadMarchas;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
        }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
            :this(cantidadRuedas,cantidadPuertas,color,0)
        { 
        
        
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de ruedas: {this.cantidadRuedas}");
            sb.AppendLine($"Cantidad de puertas: {this.cantidadPuertas}");
            sb.AppendLine($"Color: {this.color}");

            return sb.ToString();
        }

    }
}
