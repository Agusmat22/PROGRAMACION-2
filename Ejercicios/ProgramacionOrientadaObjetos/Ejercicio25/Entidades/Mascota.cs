using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
El dueño de una veterinaria nos contrató para que desarrollemos una aplicación 
donde pueda consultar la lista de clientes y sus mascotas.

De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación. 
Los primeros tres datos son obligatorios para dar de alta una mascota, mientras que el último arrancará vacío 
y se podrá ir agregando vacunas. De las vacunas sólo interesa conocer el nombre.*/

namespace Entidades
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string[] vacunas;

        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;

            vacunas = new string[20];
        }
        /// <summary>
        /// SIEMPRE LA SOBRECARGA DE CONSTRUCTORES SE COLOCA EL :THIS y por parametro solamente los nombres, no los tipos
        /// </summary>
        /// <param name="especie"></param>
        /// <param name="nombre"></param>
        /// <param name="fechaDeNacimiento"></param>
        /// <param name="vacuna"></param>
        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento,string vacuna)
            :this(especie,nombre,fechaDeNacimiento)
        {
            AplicarVacuna(vacuna);
        }


        public void AplicarVacuna(string vacuna)
        {
            for (int i = 0; i < this.vacunas.Length; i++)
            {
                if(this.vacunas[i] == null)
                {
                    this.vacunas[i] = vacuna;
                    break;
                }

            }
        }

        private string VacunasAplicadas()
        {
            string vacunasAplicadas = "";

            for (int i = 0; i < this.vacunas.Length; i++)
            {
                if (vacunas[i] != null)
                {
                    vacunasAplicadas += $"{vacunas[i]}, ";
                }
            }
            return vacunasAplicadas;

        }

        private int CantidadVacunas()
        {
            int vacuna = 0;

            for (int i = 0; i < this.vacunas.Length; i++)
            {
                if (vacunas[i] != null)
                {
                    vacuna ++;
                }
            }

            return vacuna;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Especie: {this.especie}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            sb.Append($"Vacunas aplicadas: ");

            if (CantidadVacunas() > 0)
            {
                sb.Append(VacunasAplicadas());
            }
            else
            {
                sb.Append("No contiene");
            }



            return sb.ToString();
        }

    }
}
