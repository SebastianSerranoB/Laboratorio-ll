namespace clase01_ej04
{
//    Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos(excluido el mismo) que son divisores del número.

//El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

//Escribir una aplicación que encuentre los 4 primeros números perfectos.


    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumerosPerfectos = 0;
            int acumuladorDivisores = 0;
            int valor = 2;

            //para evitar la division por 0 aunque la IDE nos permite tomarla como excepcion si deseamos, pero nos advierte
            //Los primeros ocho números perfectos
           // Los primeros ocho números perfectos son:

                //6
                //28
                //496
                //8128
                //550.336
                //589.869.056
                //438.691.328
                //2 305 843 008 139 952 128.
            do
            {
                for (int i = 1; i < valor; i++)
                {
                    if (valor % i == 0)
                    {
                        acumuladorDivisores += i;
                    }
                }

                if (acumuladorDivisores == valor)
                {
                    Console.WriteLine("Numero perfecto: {0}.", valor);
                    contadorNumerosPerfectos++;
                }
                else
                {
                    valor++;
                    acumuladorDivisores = 0;
                }
               

            } while (contadorNumerosPerfectos < 4);
            Console.WriteLine("FIN");
            
            

        }
    }
}