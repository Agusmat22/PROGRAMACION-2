using En;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Persona> alumnos;
        private EMateria materia;
        private Persona profesor;


        public Curso(Profesor profesor)
        {
            this.profesor = profesor;
            this.materia = profesor.Materia;
            this.alumnos = new List<Persona>();
        }

        public List<Persona> Alumnos
        {
            get { return alumnos; }
        }

        public Profesor Profesor
        {
            get { return (Profesor)this.profesor; }

            set { this.profesor = value; }
        }

        //METODOS

        public string InscribirAlumno(Alumno alumno)
        {
            //Si no existe en el listado y se le puede agregar al materia, atroden
            if (this != alumno && alumno + this.materia)
            {
                alumnos.Add(alumno);
                return $"Se inscribio al alumno a la materia {this.materia}\n{alumno.Informacion}";
            }
            else
            {
                return "Ya inscripto o no se pudo inscribir el alumno a la materia " + this.materia;
            }
        }

        /// <summary>
        /// Evaluar a cada alumno del curso el profesor
        /// </summary>
        /// <param name="curso"></param>
        public static void EvaluarAlumnos(Curso curso)
        {
            foreach (Persona persona in curso.Alumnos)
            {
                curso.Profesor.Evaluar((Alumno)persona);
            }
        }

        public static string MostrarInformacionDelCurso(Curso curso)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{curso.Profesor.ToString()}");
            sb.AppendLine($"{curso.materia}");
            sb.AppendLine("Listado de alumnos: ");

            //al aplicar polimorfismo va ejecutar el ToString de la clase SubTipo
            foreach (Persona item in curso.Alumnos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();   
        }

        //SOBRECARGAS OPERADORES

        public static bool operator ==(Curso curso,Alumno alumno)
        {
            foreach (Persona persona in curso.Alumnos)
            {
                //REVISAR QUE SOBRECARGA APLICA SI LA BASE O DERIVADA
                //EN TEORIA DEBE APLICAR SOLO LA BASE
                if (persona == alumno)
                {
                    return true;
                }
            }

            return false;   
        }

        public static bool operator !=(Curso curso, Alumno alumno)
        { 
            return !(curso == alumno);
        }



    }
}
