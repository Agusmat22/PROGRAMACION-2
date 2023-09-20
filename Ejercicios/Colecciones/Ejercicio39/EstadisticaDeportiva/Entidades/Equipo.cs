using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private List<Jugador> jugadores;
        private short cantidadJugadores;
        private string nombre;

        

        private Equipo() 
        { 
           jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadJugadores, string nombre):this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            bool validarJugadorEquipo = true;

            if (equipo.jugadores.Count < equipo.cantidadJugadores)
            {
              
                foreach (Jugador player in equipo.jugadores)
                {
                    if (jugador == player)
                    {
                        validarJugadorEquipo = false;
                    }
                }

                if (validarJugadorEquipo == true)
                {
                    equipo.jugadores.Add(jugador);
                }
            }
            else
            {
                validarJugadorEquipo = false;
            }

            return validarJugadorEquipo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            if (jugadores.Count > 0)
            {
                foreach (Jugador jg in jugadores)
                {
                    sb.AppendLine($"Jugador : {jg.Mostrar}");
                }


            }

            return sb.ToString();

            
        }





    }
}
