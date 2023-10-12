using En;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private string legajo;
        private Dictionary<EMateria, List<int>> materiasAsignadas;

        private Alumno(int dni):base(dni)
        {
            this.materiasAsignadas = new Dictionary<EMateria, List<int>>();
        }

        public Alumno(int dni,string legajo):this(dni)
        {
            this.legajo = legajo;
        }

        public List<int> this[EMateria materia]
        {
            get
            {
                foreach (KeyValuePair<EMateria,List<int>> item in materiasAsignadas)
                {
                    if (item.Key == materia)
                    {
                        return item.Value;
                    }
                }

                return null;
            }
        }

        //SOBRECARGA OPERADORES Y CONVERSION

        public static bool operator ==(Alumno a, EMateria materia)
        {
            foreach (EMateria item in a.materiasAsignadas.Keys)
            {
                if (item == materia)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Alumno a, EMateria materia)
        {
            return !(a == materia);
        }

        public static bool operator +(Alumno alumno, EMateria materia)
        {
            if (alumno != materia)
            {
                alumno.materiasAsignadas.Add(materia, new List<int>());

                return true;
            }
            else
            {
                return false;
            }
        }

        public static implicit operator Alumno(string dni)
        {

            if (int.TryParse(dni,out int documento))
            {
                Alumno alumno = new Alumno(documento);

                alumno.legajo = alumno.GetHashCode().ToString();
                
                return alumno;
            }

            return null;

        }


        //METODO
        public bool RendirExamen(EMateria materia)
        {
            if (this == materia)
            {
                Random random = new Random();
                this.materiasAsignadas[materia].Add(random.Next(1,11)); 
                return true;
            }
            else
            {
                return false;
            }
        }



        //POLIMORFISMO METODOS SOBRECARGADOS
        public override string Informacion
        {
            get { return $"Alumno -\n{MostrarDatos()}"; }
        }

        public override string ToString()
        {
            return $"Alumno - {this.legajo}";
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Legajo: {this.legajo}");

            if (materiasAsignadas.Count > 0)
            {
                sb.AppendLine("Materias:");
                foreach (KeyValuePair<EMateria, List<int>> item in materiasAsignadas)
                {
                    sb.Append($" {item.Key.ToString()} ");  
                }
            }
            else
            {
                sb.AppendLine("No contiene materias asignadas");
            }

            return sb.ToString();
        }
            


    }
}
