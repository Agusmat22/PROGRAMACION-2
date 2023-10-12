using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Comida;

namespace Entidades
{
    public class Hamburguesa : Comida
    {
        private static double costoBase;
        private bool esDoble;

        static Hamburguesa()
        {
            costoBase = 1500;
        }

        public Hamburguesa(string nombre):base(nombre)
        {

        }

        public Hamburguesa(string nombre,bool esDoble) : this(nombre)
        {
            this.esDoble = esDoble;
        }

        protected override string AgregarIngrediente(EIngredientes ingrediente)
        {
            string mensaje;

            if ((Comida)this != ingrediente)
            {
                base.ingredientes.Add(ingrediente);
                mensaje = $"Se agrego {ingrediente} a su hamburguesa";
            }
            else
            {
                mensaje = $"No se pudo agregar {ingrediente} a su hamburguesa";

            }

            return mensaje;
        }

        public override string ToString() 
        {
            string mensaje;

            if (this.esDoble == true)
            {
                mensaje = $"Hamburguesa - Doble";
            }
            else
            {
                mensaje = $"Hamburguesa - Simple";

            }

            return mensaje;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine(this.ToString());

            return sb.ToString();
        }

        protected override double CalcularCosto()
        {
            double precioFinal = Hamburguesa.costoBase;
            double porcentaje = 0;


            if (this.esDoble)
            {
                precioFinal += 500;
            }

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
