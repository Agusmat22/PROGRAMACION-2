using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public enum ETipo
        {
            Ciclomotor = 10,
            Scooter = 20,
            Sport = 30
        }

        private Vehiculo.EReparacion reparacion;

        public Moto(string patente,ETipo tipo) : base(tipo.ToString(), patente)
        {
            this.reparacion = Vehiculo.EReparacion.Aceite;
        }

        public override string TicketDeReparacion
        {
            get
            {
                if (this.CalcularCostoReparacion())
                {
                    return "Moto aun en taller";
                }
                else
                {
                    return $"Ticket Nro {this.GetHashCode()}\nImporte: ${this.costoDeReparacion}";
                }
            }
        }

        public EReparacion ElementoAReparar
        {
            get
            {
                return this.reparacion;
            }
        }

        protected override bool CalcularCostoReparacion()
        {
            if (this.estadoDeReparacion == true)
            {
                //Enum.Parse(typeof(ETipo),base.marca);

                this.costoDeReparacion = ((int)this.ElementoAReparar * (int)Enum.Parse(typeof(ETipo), base.marca)) / 100;
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
