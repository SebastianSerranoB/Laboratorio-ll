using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JugadoresEncapsulados_Herencia
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) :base(dni, nombre)
        {
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) :this(dni, nombre) 
        {
            this.totalGoles = totalGoles;
            partidosJugados = totalPartidos;
        }

        public int PartidosJugados 
        {
            get { 
                return partidosJugados;
            }

            set { 
            
                if(value > -1)
                this.partidosJugados=value;
            } 
        }

        public int TotalGoles 
        {
            get
            {
                return this.totalGoles;
            }

            set 
            {
                if (value > -1)
                    this.totalGoles = value;
            }

        
        }


        public float PromedioDeGoles
        {
            get
            {
                if (this.partidosJugados > 0 && this.totalGoles > 0)
                    return (float)this.totalGoles / this.partidosJugados;

                else
                    return 0;
            
            }
        }


        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Total goles: {this.partidosJugados}");
            sb.AppendLine($"Promedio de Goles: {this.PromedioDeGoles}");


            return base.MostrarDatos() + sb.ToString();
        }

        //MostrarDatos() como hacemos?

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1 is not null && j2 is not null)
            { 
                return ( (j1.Dni == j2.Dni) && (j2.Nombre == j2.Nombre) );
            }

            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }



    }
}
