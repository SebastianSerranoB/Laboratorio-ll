namespace clase01_ej03
{
    /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

      Validar que el dato ingresado por el usuario sea un número.

      Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

      Si ingresa "salir", cerrar la consola.

      Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
    */


    //numero primo si es mayor que 1, y es divisible solo por el mismo numero y por 1
    //goto
    //enviroment.exit
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            // el "?" es para que ignore el echo de que puede ser NULL el string, es para evitar un warning cuando lo llamamos
            string? opcion;
            bool flag;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                flag = int.TryParse(Console.ReadLine(), out numeroIngresado);

                if(flag != false)
                {
                    Console.WriteLine("Los numeros primos de {0} son: ", numeroIngresado);
                    for (int i = 1; i < numeroIngresado; i++)
                    {
                        if (i / i == 1 && i / 1 == i && i % 2 != 0)
                        {
                            Console.WriteLine("{0}, ", i);
                        }
                    }
                }
              
                Console.WriteLine("¿Desea ingresar otro numero? : si || salir ");
                opcion = Console.ReadLine();
                while(opcion != "si" && opcion != "salir")
                {
                    Console.WriteLine("Error! Ingrese una opcion valida: (si  -  salir)");
                    opcion = Console.ReadLine();
                }


            } while (opcion != "salir");
        }
    }
}