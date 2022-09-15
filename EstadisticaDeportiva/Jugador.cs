using System.Text;

namespace EstadisticaDeportiva
{
    public class Jugador  //pero no invalida objetc equals sobrecarga de operadores
    {
        private int dni;
        private string? nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = string.Empty;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string? nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string? nombre, int totalGoles, int partidosJugados) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public string Nombre
        {
            get {
                return this.nombre; //que hacemos con los posibles null
            }
            set {
                this.nombre = value;
            }
        }

        public int Dni
        {
            get {
                return this.dni;
            }
            set 
            { 
                this.dni = value;
            }
        
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public float PromedioDeGoles
        {
            get
            {
                float promedioGoles = -1;
                if (this.partidosJugados > 0 && this.totalGoles != 0)
                {
                    promedioGoles = (float)this.totalGoles / this.partidosJugados;
                }

                return promedioGoles;
            }
           
        }

        public string MostrarDatos()
        { 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nNombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Total de goles: {this.totalGoles}");
            sb.AppendLine($"Promedio de goles: {this.PromedioDeGoles}");
         
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }



    }
}