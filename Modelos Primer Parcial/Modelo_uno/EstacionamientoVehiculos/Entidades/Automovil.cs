using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private EReparacion elementoAReparar;
        private double manoDeObra;
            
        public Automovil(string patente, string marca) :base(marca,patente)
        {
            this.manoDeObra = 932.99D;
           
        }

        public Automovil(string patente,string marca, EReparacion reparacion)
            :this(patente,marca)
        {
            this.elementoAReparar = reparacion;
        }

        //PROPERTY
        public EReparacion ElementoAReparar 
        {
            get
            {
               return this.elementoAReparar;
            }
            
        }
        public double ManoDeObra
        {
            get
            {
                return this.manoDeObra;
            }
            set
            {
                if (value > this.ManoDeObra)
                {
                    this.manoDeObra = value;   
                }
            }
        }

        public override string TicketDeReparacion
        {
            get
            {
                if (this.CalcularCostoReparacion())
                {
                    return "$Automovil aun en taller";
                }
                else
                {
                    return $"Ticket Nro {this.GetHashCode()}\nImporte: ${this.costoDeReparacion}";
                }
            }
        }


        //METHOD
        protected override bool CalcularCostoReparacion()
        {
            if (this.estadoDeReparacion == true)
            {
                this.costoDeReparacion = this.ManoDeObra + (int)this.ElementoAReparar;
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Elemento a reparar: {this.ElementoAReparar}");
            sb.AppendLine($"Ticket De Reparacion: {this.TicketDeReparacion}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }





    }
}
