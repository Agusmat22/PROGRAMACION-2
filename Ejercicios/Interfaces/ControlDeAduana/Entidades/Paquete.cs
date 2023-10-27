using Entidades.Interfaces;
using System.Text;

namespace Entidades
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get; }

        //Implementando la propiedad implicita de la interfaz

        public decimal Impuestos
        {
            get
            {         //CALCULA EL 35% DE IMPUESTO
                decimal impuestoAgregado = this.costoEnvio * 0.35m;
                return impuestoAgregado;
            }
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos;
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: {this.costoEnvio}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Peso x KG: {this.pesoKg}");

            return sb.ToString();
        }

        

    }
}