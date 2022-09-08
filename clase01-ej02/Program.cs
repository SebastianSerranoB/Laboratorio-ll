namespace clase01_ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            //tipo de dato bool, es binariom solo puede ser TRUE o FALSE
            bool flag;
            
            //WriteLine imprime linea por consola y hace un salto de linea, "\n, \0"
            Console.WriteLine("Ingrese un numero: ");
           // numero = double.Parse (Console.ReadLine());
           //.TryParse es el metodo que verifica si es posible la conversion de lo ingresado por consola en el tipo de dato que queremos (double en este caso), si numero fuera una letra, la flag seria FALSE y rebotaria en el while
            //Console.ReadLine() toma // levanta un dato por consola
            flag = double.TryParse(Console.ReadLine(), out numero);
            //bool resultado = int.TryParse(numString, out numero);

            do
            {
                Console.WriteLine("ERROR. ¡Reingresar número! ");
                flag = double.TryParse(Console.ReadLine(), out numero);
            }while(numero <= 0 || flag == false);

            
            Console.WriteLine("El numero al cuadrado es: {0} y el numero al cubo es: {1}", numero*numero, numero*numero*numero);
        }
    }
}