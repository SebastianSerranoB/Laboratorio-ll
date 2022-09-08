using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02_ej03
{
    internal class Conversor
    {

        //Otro método más simple para convertir una variable de entero decimal en una variable de cadena binaria es usar la función Convert.ToString() en C#.
        //    El Convert.ToString(dec, 2) convierte el dec a la base 2 y devuelve el resultado en forma de cadena. 
       
        //metodo convencional, sin atajos de lenguaje
        public static string ConvertirDecimalABinario(int numeroDecimal)
        {
            int resto;
            string binario = string.Empty;

            while (numeroDecimal > 0)
            { 
                resto = numeroDecimal % 2;
                numeroDecimal /= 2;
                binario = resto.ToString() + binario;
            }
           
            return binario;
        }

        public static int ConvertirBinarioADecimal(int numeroBinario) 
        {
            int numero=0;
            int digito=0;
            const int DIVISOR = 10;

            //comas, punto y coma en FOR c#; que criterio se utiliza?
            for (int i = numeroBinario, j = 0; i > 0; i /= DIVISOR,j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    Console.WriteLine("El numero ingresado no es binario!");
                    return -1;
                }

                numero += digito * (int)Math.Pow(2, j);
            
            }

            return numero;
        }



    }
}


//namespace convert_int_to_binary
//{
//    class Program
//    {
//        static void method1()
//        {
//            int decimalNumber = 15;
//            int remainder;
//            string binary = string.Empty;

//            while (decimalNumber > 0)
//            {
//                remainder = decimalNumber % 2;
//                decimalNumber /= 2;
//                binary = remainder.ToString() + binary;
//            }
//            Console.WriteLine("Binary:  {0}", binary);
//        }
//        static void Main(string[] args)
//        {
//            method1();
//        }
//    }
//}


//Ejercicio I03 - Conversor binario
//Consigna
//Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

//El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

//public string ConvertirDecimalABinario(int numeroEntero) { }

//El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

//public int ConvertirBinarioADecimal(int numeroEntero) { }

//IMPORTANTE
//NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.