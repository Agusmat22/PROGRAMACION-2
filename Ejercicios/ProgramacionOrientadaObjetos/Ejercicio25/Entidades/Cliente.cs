/*
El dueño de una veterinaria nos contrató para que desarrollemos una aplicación 
donde pueda consultar la lista de clientes y sus mascotas.

De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. 
A un cliente se le pueden asociar una o más mascotas.

*/
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private long telefono;

        List<Mascota> mascotas;

        public Cliente(string nombre, string apellido, string domicilio, long telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;

            this.mascotas = new List<Mascota>();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Domicilio: {this.domicilio}");
            sb.AppendLine($"Telefono: {this.telefono}");
            sb.AppendLine($"Cantidad de mascotas: {CantidadMascotas()}");

            return sb.ToString();
        }

        public string MostrarMascotas()
        {
            StringBuilder sb = new StringBuilder();

            if (mascotas.Count > 0)
            {
                

                foreach (Mascota mascota in this.mascotas)
                {
                    sb.AppendLine(mascota.Mostrar()+"\n\n");
                }

            }
            else
            {
                sb.AppendLine("No contiene mascotas");
            }

            return sb.ToString();   
        }

        /// <summary>
        /// Indica la cantidad de mascotas que tiene el cliente
        /// </summary>
        /// <returns></returns>
        private int CantidadMascotas()
        {
            return this.mascotas.Count;
        }

        public void AgregarMascota(Mascota mascota)
        {
            this.mascotas.Add(mascota);
        }

        
    }
}