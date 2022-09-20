using System.Data.Common;
using System.Net;
using System.Text;

namespace Carreras
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string? escuderia;
        private short numero;
        private short vueltasRestantes;

        private AutoF1()
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
        }

        public AutoF1(short numero, string escuderia) : this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }



       
        public short CantidadCombustible
        { 
            get
            { return this.cantidadCombustible; }

            set 
            {
                if(value > -1)
                { this.cantidadCombustible = value;}
                   
            }
        }

        public bool EnCompetencia
        {
            get
            { return this.enCompetencia; }

            set
            { this.enCompetencia = value;}
        }

        public short VueltasRestantes
        {
            get 
            { return this.vueltasRestantes;}
            set
            { 
                if(value > -1)
                { this.vueltasRestantes = value;}
             }
        }


        public string MostrarDatos()
        {
           StringBuilder sb = new StringBuilder();

            sb.AppendLine("Escuderia: " + this.escuderia);
            sb.AppendLine("Numero " + this.numero);
            if (this.enCompetencia)
            {
                sb.AppendLine("Compitiendo actualmente");
                sb.AppendLine("Vueltas restantes: " + this.vueltasRestantes);
                sb.AppendLine("Combustible restante: " + this.cantidadCombustible);
            }
            else
            { 
                sb.AppendLine("No esta compitiendo");
            }
           
            return sb.ToString();
        }


        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        { 
            return ( (a1.escuderia == a2.escuderia)  && (a1.numero == a2.numero) );
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}