using Clase_02_Ej01;
namespace clase02_ej02
{

    internal class Program
    {
        static void Main(string[] args)
        {
           ConsoleKeyInfo respuesta;
            bool flagIngresoDeNumero;
            int sumaDeEnteros = 0;
            int numeroIngresado;

            do
            {
                Console.WriteLine("Ingrese un numero entero para sumarlo: ");
                flagIngresoDeNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                while (!flagIngresoDeNumero) 
                {
                    Console.WriteLine("Error! Ingrese un numero entero valido: ");
                    flagIngresoDeNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                sumaDeEnteros += numeroIngresado;


                Console.WriteLine("¿Desea ingresar otro numero: S o N ?");
                respuesta = Console.ReadKey(true);
                 while (Char.ToUpper(respuesta.KeyChar) != 'S' && Char.ToUpper(respuesta.KeyChar) != 'N')  //permite solo mayusculas, ToUpper() ?
                {
                    Console.WriteLine("Error! reingrese su respuesta: S || N .");
                    respuesta = Console.ReadKey(true);
                }
                
            } while (Validador.ValidarRespuesta(respuesta.KeyChar));
            Console.WriteLine("La suma total es: {0}", sumaDeEnteros);
            Console.WriteLine("Fin del programa..");
           
        }
    }
}

//Consigna
//Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

//Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

//El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

//Resolución