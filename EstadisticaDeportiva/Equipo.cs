using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadisticaDeportiva
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores; 
        private string? nombre;

        private Equipo()
        { 
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string? nombre) : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool flag = true;
            bool retorno = false;
            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador == j)
                {
                    flag = false;
                }
            }

            if (e.cantidadDeJugadores >= e.jugadores.Count + 1 && flag)
            {
                e.jugadores.Add(j);
                retorno = true;
            }

            return retorno;
        }
    }
}
