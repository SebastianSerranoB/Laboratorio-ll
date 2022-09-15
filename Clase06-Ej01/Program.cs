using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System;
using System.Globalization;

namespace Clase06_Ej01
{
    //LO HICE COMO ARREGLOS EN C


    internal class Program
    {
        static void Main(string[] args)
        {
            Random numeroRandom = new Random();
            int[] arrayEnteros = new int[20];
            int auxiliar;


            // ASIGNAMOS 20 NUMEROS CON CLASE RANDOM ENTRE -100 Y 100
            for (int j = 0; j < arrayEnteros.Length; j++)
            {
                arrayEnteros[j] = numeroRandom.Next(-100,100);
            }

            Console.WriteLine("Lista de numeros: ");
            for (int i = 0; i < arrayEnteros.Length; i++)
            { 
                Console.WriteLine(arrayEnteros[i]);
            }

            //CARGAMOS DOS ARREGLOS, UNO CON POSITIVOS OTRO CON NEGATIVOS, DERIVADOS DEL PRIMER FOR




           
            for (int i = 0; i < arrayEnteros.Length-1; i++)
            {
                for (int j = i + 1; j < arrayEnteros.Length; j++)
                {
                    if (arrayEnteros[i] < arrayEnteros[j])
                    { 
                        auxiliar = arrayEnteros[i];
                        arrayEnteros[i] = arrayEnteros[j];
                        arrayEnteros[j] = auxiliar;
                    }
                }
            }
            Console.WriteLine("POSITIVOS DECRECIENTES: ");
            for (int i = 0; i < arrayEnteros.Length; i++)
            {
                if (arrayEnteros[i] > -1)
                {
                    Console.WriteLine(arrayEnteros[i]);
                }
            }

            
            
            for (int i = 0; i < arrayEnteros.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayEnteros.Length; j++)
                {
                    if (arrayEnteros[i] > arrayEnteros[j])
                    {
                        auxiliar = arrayEnteros[i];
                        arrayEnteros[i] = arrayEnteros[j];
                        arrayEnteros[j] = auxiliar;
                    }
                }
            }
            Console.WriteLine("NEGATIVOS ASCENDIENTES: ");
            for (int i = 0; i < arrayEnteros.Length; i++)
            {
                if (arrayEnteros[i] < 0)
                {
                    Console.WriteLine(arrayEnteros[i]);
                }
            }

        }
    }
}

//Interpreto que este primer ejercicio, es con un array tipico, [];

//Ejercicio I01 - Números locos
//Consigna
//Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

//Mostrar el vector tal como fue ingresado.
//Luego mostrar los positivos ordenados en forma decreciente.
//Por último, mostrar los negativos ordenados en forma creciente.