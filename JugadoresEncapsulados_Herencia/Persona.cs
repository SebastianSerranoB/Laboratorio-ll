using System.Text;

namespace JugadoresEncapsulados_Herencia
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
           this.nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        public long Dni 
        {
            get {
            
                return this.dni;
            }


            set { 
                if(value > 0)
                this.dni = value;
            }
        }

        public string Nombre 
        {
            get {
                return this.nombre;
            }

            set{
                if (!(string.IsNullOrEmpty(value) ) )
                {
                    this.nombre = value;
                }
            }
        
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"DNI: {this.dni}");
            
            return sb.ToString();
        }






    }
}