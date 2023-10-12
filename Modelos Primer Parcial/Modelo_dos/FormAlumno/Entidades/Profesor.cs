using En;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private string email;
        private EMateria materiaAsignada;


        public Profesor(int dni):base(dni)
        {

        }

        public Profesor(int dni,string email):this(dni)
        {
            this.email = email;
        }

        public Profesor(int dni, string email,EMateria materiaAsignada) : this(dni,email)
        {
            this.materiaAsignada = materiaAsignada;
        }


        public EMateria Materia
        {
            get { return materiaAsignada; }
            set { materiaAsignada = value; }
        }

        //POLIMORFISMO SOBRECARGA

        public override string Informacion
        {
            get { return $"Profesor -\n{MostrarDatos()}"; }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Email: {this.email}");
            sb.AppendLine($"Materia asignada para dar clase: {this.materiaAsignada.ToString()}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"Profesor - {this.materiaAsignada}";
        }

        //METODO DE LA CLASE

        public bool Evaluar(Alumno alumno)
        {
            return alumno.RendirExamen(this.materiaAsignada);
        }


    }
}
