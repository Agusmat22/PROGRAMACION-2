using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guarnicion : Comida
    {
        public enum ETipo
        {
            PAPAS_FRISTAS=1000,
            ENSALADA_RUSA=750,
            ENSALADA_MIXTA=500
        }
        
        private ETipo tipo;

        public Guarnicion():this(ETipo.PAPAS_FRISTAS)
        {

        }

        public Guarnicion(ETipo tipo):base(tipo.ToString())
        {
            this.tipo = tipo;
        }

        //SOBRECARGA
        
        public static bool operator ==(Guarnicion g,EIngredientes ingrediente)
        {
            if (ingrediente is EIngredientes.PANCETA || ingrediente is EIngredientes.ADHERESO ||
                ingrediente is EIngredientes.QUESO)
            {
                return true;
            }

            return false;
        }


        public static bool operator !=(Guarnicion g, EIngredientes ingrediente)
        { 
            return !(g == ingrediente);
        }

        public override string ToString()
        {
            return $"Guarnicion del tipo {this.tipo}";
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine(this.ToString());

            return sb.ToString();
        }

        protected override string AgregarIngrediente(EIngredientes ingrediente)
        {
            if (this + ingrediente && this == ingrediente)
            {
                return $"Se agrego {ingrediente} a su guarnicion";
            }
            else
            {
                return $"No se pudo agregar {ingrediente} a su guarnicion";
            }
        }

        protected override double CalcularCosto()
        {
            double precioFinal = (int)tipo;
            double porcentaje = 0;

            if (base.ingredientes.Count > 0)
            {
                foreach (EIngredientes item in base.ingredientes)
                {
                    porcentaje += (int)item;
                }

                //agrego el porcentaje
                precioFinal += (precioFinal * porcentaje) / 100;

            }

            return precioFinal;
        }
    }
}
