using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EReparacion
        {
            Ruedas = 500,
            Aceite = 3000,
            Frenos = 5400
        }

        protected double costoDeReparacion;
        protected bool estadoDeReparacion;
        protected string marca;
        protected string patente;

        protected Vehiculo(string marca, string patente)
        {
            this.marca = marca;
            this.patente = patente;
            this.estadoDeReparacion = false;
            this.costoDeReparacion = 0;
        }

        //PROPERTY
        protected string EstadoDeReparacion 
        {
            get 
            {
                if (this.estadoDeReparacion == true)
                {
                    return "Reparado";
                }
                else
                {
                    return "Reparacion Pendiente";
                }

            }

        }

        public abstract string TicketDeReparacion { get; }

        //METHOD

        protected abstract bool CalcularCostoReparacion();


        public override bool Equals(object? obj)
        {
            if (obj is Vehiculo vehiculo)
            {
                return this.patente == vehiculo.patente;
            }

            return false;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Patente: {this.patente}");
            sb.AppendLine($"Costo de reparacion: {this.costoDeReparacion}");

            return sb.ToString();   
        }

        public static void RepararVehiculo(Vehiculo vehiculo)
        {
            vehiculo.estadoDeReparacion = true;
        }

    }
}