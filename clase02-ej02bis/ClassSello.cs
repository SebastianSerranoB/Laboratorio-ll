using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02_ej02bis
{
    public static class Sello
    {

        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {


            // return ArmarFormatoMensaje(); Seria valido 
            return Sello.ArmarFormatoMensaje();

        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.BackgroundColor = color;
            Console.WriteLine(Sello.mensaje);
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            string mensajeFormateado;
            string formato = string.Empty;   // en ves de  = ""

            for (int i = 0; i <= mensaje.Length+1; i++)
            {
                formato += "*";
            }
            mensajeFormateado = formato + "\n" + "*" + Sello.mensaje + "*" + "\n" + formato;



            return mensajeFormateado;
        }

    }

  
}


//clase Sello

//(+) mensaje: string



//(+) Imprimir() : string ---> return Sello.mensaje;

//(+) Borrar() : void ----->Sello.mensaje = "";