using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadoresEncapsulados_Herencia
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;


        private Equipo()
        {
            cantidadDeJugadores = -1;
            jugadores = new List<Jugador>();
            nombre = string.Empty;
        }

        public Equipo(short cantidad, string nombre) : this()
        { 
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            Equipo equipo = new Equipo();

            if (e is not null && j is not null)
            {

                foreach (Jugador jugadorAux in e.jugadores)
                {
                    if (jugadorAux == j)
                    {
                        Console.WriteLine("El jugador ya existe en el equipo.");
                        return equipo;
                    }
                    
                }

                e.jugadores.Add(j);
                Console.WriteLine("Se añadio un jugador al equipo.");
                return e;
            
            }

            return equipo;
        }




    }
}
