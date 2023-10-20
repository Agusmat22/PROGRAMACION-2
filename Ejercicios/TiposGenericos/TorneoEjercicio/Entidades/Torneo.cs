using System;
using System.Text;

namespace Entidades
{
    //Tipo generico T, limito el Tipo de dato ingresado que solo puede ser la clase PADRE y sus derivadas
    public class Torneo<T> where T : Equipo
    {
        private List<T> lista;
        private string nombre;

        public List<T> Lista { get => lista; set => lista = value; }

        
        public string Nombre { get => nombre; set => nombre = value; }

        //La propiedad pública JugarPartido tomará dos equipos de la lista al azar
        //y calculará el resultado del partido a través del método CalcularPartido.

        public string JugarPartido
        {
            get
            {
                if (lista.Count > 1)
                {
                    Random random = new Random();
                    int cantidadEquipos = this.Lista.Count;

                    int numeroRandom = random.Next(0, (cantidadEquipos - 2));

                    return CalcularPartido(this.Lista[numeroRandom], this.Lista[numeroRandom+1]);
                    
                }

                throw new ArgumentNullException();

            }

        }



        private Torneo()
        {
            lista = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        //METODOS

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Torneo {this.Nombre}\nEquipos: ");

            if (this.Lista.Count > 0)
            {
                foreach (T item in this.Lista)
                {
                    sb.AppendLine($"{item.Ficha}");
                }
            }

            return sb.ToString();   
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();

            return $"{equipo1.Nombre} {random.Next(0, 10)} - {random.Next(0, 10)} {equipo2.Nombre}";
        }

        //SOBRECARGA DE OPERADORES

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            if (torneo.Lista.Count > 0)
            {
                foreach (T item in torneo.Lista)
                {

                    if (item == equipo)
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {

            if (torneo != equipo)
            {
                torneo.Lista.Add(equipo);

                return true;
            }

            return false;
        }
    }
}