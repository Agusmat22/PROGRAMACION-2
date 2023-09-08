/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.

CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.

Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.

EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.

Instanciar 3 objetos de tipo Persona en el método Main.

Mostrar quiénes son mayores de edad y quiénes no.


*/
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private long dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, long dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        //SETTER Y GETTER

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string dato)
        {
            if (!string.IsNullOrEmpty(dato))
            {
                this.nombre = dato;
            }
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public void SetFechaDeNacimiento(DateTime fecha)
        {     
            this.fechaDeNacimiento = fecha;   
        }

        public long GetDni()
        {
            return this.dni;
        }

        public void SetDni(long dato)
        {
            this.dni = dato;  
        }

        /// <summary>
        /// Calcula la edad en base a la fecha de nacimiento ingresada
        /// </summary>
        /// <returns></returns>
        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;

            int edad = fechaActual.Year - this.fechaDeNacimiento.Year;

            if (fechaActual.Month < fechaDeNacimiento.Month || fechaActual.Month == fechaDeNacimiento.Month && fechaActual.Day < fechaDeNacimiento.Day)
            {
                edad--;
            }

            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Edad: {this.CalcularEdad()}");

            return sb.ToString();
        }


        public bool EsMayorDeEdad()
        {
            if (CalcularEdad() > 17)
            {
                return true;
            }

            return false;
        }
    }
}