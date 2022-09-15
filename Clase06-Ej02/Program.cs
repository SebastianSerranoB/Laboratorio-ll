using System.Collections;

namespace Clase06_Ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random numeroRandom = new Random();
            List<int> listRandom = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                listRandom.Add(numeroRandom.Next(-100, 100));
            }
            Console.WriteLine("Lista original tipo List: ");
            foreach (int numeroLista in listRandom)
            {
                Console.WriteLine(numeroLista);
            }
            
             listRandom.Sort(OrdenDescendente);
            Console.WriteLine("Tipo List ordenada de manera descendiente: ");
            foreach (int numeroLista in listRandom)
            {
                Console.WriteLine(numeroLista);
            }
            */

            List<int> lista = new List<int>();
            Queue<int> colaPos = new Queue<int>();
            Stack<int> pilaPos = new Stack<int>();
            Queue<int> colaNeg = new Queue<int>();
            Stack<int> pilaNeg = new Stack<int>();

            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(r.Next(-100, 100));
            }


            Console.WriteLine("Lista Original");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista Ordenada decreciente");
            lista.Sort(Program.OrdenDescendente);
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista Positivos");
            foreach (int i in lista)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                    colaPos.Enqueue(i);//agrego positivo a la cola de positivos
                }
                else if (i != 0)//evito el cero
                {
                    pilaNeg.Push(i);//agrego negativos a la lista de negativos
                }
            }
            Console.WriteLine("Lista Negativos");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] > 0)
                {
                    pilaPos.Push(lista[i]);//agrego positivo a la pila de positivos
                }
                else if (i != 0)//evito el cero
                {
                    Console.WriteLine(lista[i]);
                    colaNeg.Enqueue(lista[i]);//agrego negativos a la lista de negativos
                }
            }
            Console.WriteLine(" Cola Positivos");
            foreach (int i in colaPos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Positivos");
            foreach (int i in pilaPos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Cola Negativos");
            foreach (int i in colaNeg)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Negativos");
            foreach (int i in pilaNeg)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();






















        }

        //metodo criterio de orden
        public static int OrdenDescendente(int a, int b)
        {
            return b - a;
        }

    }


}
    


/*
 * Ejercicio I02 - Números locos II
Consigna
Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

Mostrar la colección tal como fue cargada.
Luego mostrar los positivos ordenados en forma decreciente.
Por último, mostrar los negativos ordenados en forma creciente
 * 
 */