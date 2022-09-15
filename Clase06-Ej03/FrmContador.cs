namespace Clase06_Ej03
{
    public partial class FrmContador : Form
    {
        Dictionary<string, int> miDiccionario;
        public FrmContador()
        {
            miDiccionario = new Dictionary<string, int>();
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            string textoBruto = this.richTxtBoxDiccionario.Text;
            string[] textoFiltro = textoBruto.Split(' ', '\t');  // \u002C este figuraba por defecto


            richTxtBoxDiccionario.Clear();


            /*  foreach (string str in textoFiltro)
              {
                  this.richTxtBoxDiccionario.AppendText($"\n{str}");
              }*/

            // foreach (Dictionary<string, int> palabra  in miDiccionario)
            //  { 

            //}

            textoBruto.Trim(); // elimina espacios blancos de el principio y al final
          //  textoBruto.Concat;//concatena
          //substring, contains compare    substring(desdeIndice, cantidadDeChars);
          //to lower , toupper
          
           
           




            //convertir texto en palabras, 
            //si se repite la palabra sube su contador, "palabra, contador" "key, value"
            //filtrar con array propiedad que convierte string, y lo separa/formatea en array, 
            //recorrer en un foreach si coincide con las palabras de mi diccionario, si la key coincide, sube le vale

        }
    }
}

/*
 * Utilizar diccionarios (Dictionary<string, int>) para realizar un contador de palabras.

    Se deberá recorrer el texto ingresado palabra por palabra. Si se trata de una nueva palabra,
    se la agregará al diccionario y se inicializará su contador en 1. Caso contrario, se deberá incrementar dicho contador.
    Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra.
    Al presionar el botón Calcular informar mediante un MessageBox el TOP 3 de palabras con más apariciones.
 * 
 */