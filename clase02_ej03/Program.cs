namespace clase02_ej03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flagIngreso;
            int numeroIngresado;


            Console.WriteLine("Ingrese un numero entero: ");
            flagIngreso = int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!flagIngreso)
            {
                Console.WriteLine("Error! Ingrese un numero entero: ");
                flagIngreso = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            
            Console.WriteLine("El numero ingresado en sistema binario es: {0}", Conversor.ConvertirDecimalABinario(numeroIngresado));

            Console.WriteLine("Ingrese un numero binario: ");
            flagIngreso = int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!flagIngreso)
            {
                Console.WriteLine("Error! Ingrese un numero binario: ");
                flagIngreso = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }

            Console.WriteLine("El numero ingresado en sistema decimal es: {0}", Conversor.ConvertirBinarioADecimal(numeroIngresado));

        }
    }
}


//Ejercicio I03 - Conversor binario
//Consigna
//Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

//El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

//public string ConvertirDecimalABinario(int numeroEntero) { }

//El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

//public int ConvertirBinarioADecimal(int numeroEntero) { }

//IMPORTANTE
//NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.