/*
La clase Estudiante:

Tendrá un constructor estático que inicializará el atributo estático random.
Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
El método privado CalcularPromedio retornará el promedio de las dos notas.
El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre 
y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
Nombre, apellido y legajo.
Nota del primer y segundo parcial.
Promedio.
Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
Mostrar los datos de todos los alumnos.

*/
using System.Text;

namespace Entidades
{
    public class Estudiante
    {
        static Random random;
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;


        //Inicializo el constructor static que se va inicializar una sola vez por el CLR
        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string nombre, string legajo, int notaPrimerParcial, int notaSegundoParcial)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            this.notaPrimerParcial = notaPrimerParcial;
            this.notaSegundoParcial = notaSegundoParcial;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaPrimerParcial = nota;
            }
        }

        public void SetNotaSegundoParcial(int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaSegundoParcial = nota;
            }
        }

        private float CalcularPromedio()
        {
            float promedio = ((float)this.notaPrimerParcial + this.notaSegundoParcial) / 2;

            return promedio;

        }

        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial > 3 && this.notaSegundoParcial > 3)
            {
                //coloco 11 porque siempre va descontar 1 asi que en teoria seria del 6 al 10
                return random.Next(6, 11);
            }

            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota Primer Parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota Segundo Parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio Notas: {CalcularPromedio()}");

            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota final: {CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine($"Alumno Desaprobado");
            }

            return sb.ToString();   
        }

    }
}