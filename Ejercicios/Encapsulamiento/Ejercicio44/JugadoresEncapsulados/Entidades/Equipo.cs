using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores,string nombre):this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;   
        }
        public Jugador this[int indexador]
        {
            get
            {
                if (jugadores.Count > 0 && indexador < jugadores.Count && indexador > -1)
                {
                    return jugadores[indexador];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (indexador >= jugadores.Count && jugadores.Count <= this.cantidadDeJugadores)
                {
                    jugadores.Add(value);
                }
                else if (indexador >= 0)
                {
                    jugadores[indexador] = value;
                }

            }
        }

       

        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            if (equipo != jugador && equipo.jugadores.Count < equipo.cantidadDeJugadores)
            {
                equipo.jugadores.Add(jugador);
                return true;
                
            }
            else
            {
                return false; 
            }
        }

        public static bool operator ==(Equipo equipo,Jugador jugador)
        {
            if (equipo.jugadores.Count > 0)
            {
                foreach (Jugador item in equipo.jugadores)
                {
                    if (item == jugador)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }
    }
}
