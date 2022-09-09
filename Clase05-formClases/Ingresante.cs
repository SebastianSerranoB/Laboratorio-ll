using System.Text;

namespace Clase05_formClases
{
    public class Ingresante
    {
        #region Atributos

        private string[] cursos;
        private string? direccion;
        private string? genero;
        private string? nombre;
        private string? pais;
        private int edad;

        #endregion

        #region Constructor
       
        public Ingresante()
        { 
            this.cursos = Array.Empty<string>(); //strig.isEmpty para array
            this.direccion = string.Empty;
            this.genero = string.Empty;
            this.nombre = string.Empty;
            this.pais = string.Empty;
            this.edad = -1;
        }

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.edad = edad;
            this.cursos = cursos; 
        }

        #endregion


        #region Metodos
        public string Mostrar()
        {
            //creamos una instancia de StringBuilder, SB maneja siempre la misma  referencia de memoria cuando lo modificamos, a diferencia de cuanto seguimos modifando en distintas lineas una misma variable string, cada ves se instancia una nueva en memoria  a pesar de que figuren bajo el mismo identificador, el SB es mas eficiente en el sentido de que siempre es la misma memoria
            StringBuilder sB = new StringBuilder();
            sB.AppendLine($"Nombre: {this.nombre}");
            sB.AppendLine($"Direccion: {this.direccion}");
            sB.AppendLine($"Edad: {this.edad}");
            sB.AppendLine($"Genero: {this.genero}");
            sB.AppendLine($"Pais {this.pais}");
           // sB.AppendLine($"Cursos: {this.cursos}"); es un array, hay que recorrerlo
            sB.AppendLine("Cursos:");

            foreach (string curso in this.cursos) //como evito este warning de NULL? sacandole el ? en la declaracion funciono, 
            {
                if (!string.IsNullOrWhiteSpace(curso))
                {
                    sB.AppendLine($"  {curso}");
                }
            }

            
            return sB.ToString();
        }

        #endregion

    }
}