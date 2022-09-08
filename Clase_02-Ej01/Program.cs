namespace Clase_02_Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool flag;
         
            int min = 0;
            int max = 0;
            double acumulador = 0;
            double promedio;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                flag = int.TryParse(Console.ReadLine() , out numeroIngresado);

                while (!flag || !Validador.Validar(numeroIngresado, -100, 100))
                {
                    Console.WriteLine("Error! Ingrese un numero valido: ");
                    flag = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                
                // i==0
                if (i == 0 || min > numeroIngresado)
                {
                    min = numeroIngresado;
                    
                }
               
                if (i == 0 || max < numeroIngresado)
                {
                    max = numeroIngresado;
                }

                acumulador += numeroIngresado;
            }

            promedio = acumulador / 10;

            Console.WriteLine("El numero minimo es: {0}, el maximo es: {1} y el promedio de numeros ingresados fue: {2}", min, max, promedio);
        }
    }
}