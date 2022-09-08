/*
 * 
 * clase Sello

(+) mensaje : string



(+) Imprimir() : string ---> return Sello.mensaje;

(+) Borrar() : void -----> Sello.mensaje = "";




Main()

Sello.mensaje = "hola mundo"

Sello.Imprimir();//retorna string

Sello.Borrar();

Sello.Imprimir();//retorna string*/


namespace clase02_ej02bis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Sello.mensaje = "hola mundo";
            Console.WriteLine(Sello.Imprimir());
            
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.WriteLine("Funciono! primerParte");

            

            Sello.mensaje = "hola mundo C#";

            Sello.color = ConsoleColor.Red;

            Sello.ImprimirEnColor();

            Sello.Imprimir();//retorna string
            Console.WriteLine("Funciono! SegundaParte");*/

            Sello.mensaje = "hola mundooooooooooooo";
            Sello.color = ConsoleColor.Red;
             Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());

        }

    }
}

/* 
 * Sello.mensaje = "hola mundo"

Sello.Imprimir();//retorna string

Sello.Borrar();

Sello.Imprimir();//retorna string
 * 
 */

/*
 (+) Imprimir() : string -> ArmarFormatoMensaje


(+) Borrar() : void


(+) ImprimirEnColor() : void --> Imprimir


(-) ArmarFormatoMensaje() : string



Main()


Sello.mensaje = "hola mundo"


Sello.color = ConsoleColor.Red;


Sello.ImprimirEnColor();


Sello.Imprimir();


************
*hola mundo*
************
 
 */