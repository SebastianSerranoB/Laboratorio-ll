
namespace clase01_ej01
{
    /*
     * 
     * Ejercicio I01 - Máximo, mínimo y promedio
     Consigna
     Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
     * 
     */




    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int min = 0;
            int max = 0;
            int acumulador = 0;
            float promedio;
        
            bool flag;

            Console.WriteLine("Ingrese hasta 5 numeros!");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                //numeroIngresado es de tipo INT; el metodo Readline de la clase console lee datos por consola siempre en formato string, por eso hay que parsearlo
                //numeroIngresado =  Console.ReadLine();
                while(!(flag = int.TryParse(Console.ReadLine(), out numeroIngresado)))
                 {
                    Console.WriteLine("Error, ingrese un numero valido: ");
                }
                //Convierte la representación en forma de cadena de un número en el entero de 64 bits con signo equivalente.
                //Un valor devuelto(BOOL) indica si la conversión se realizó correctamente o si se produjeron errores.

                if(i == 0 || numeroIngresado < min)
                {
                    min = numeroIngresado;
                }
                if (i == 0 || numeroIngresado > max) 
                { 
                    max = numeroIngresado;  
                }
               
                acumulador += numeroIngresado;

            }
            promedio = acumulador / 5;
            Console.WriteLine("\nEl valor minimo es: {0}, el maximo fue {1} y el promedio de los 5 numeros es: {2}.",min, max, promedio);



        }
    }
}