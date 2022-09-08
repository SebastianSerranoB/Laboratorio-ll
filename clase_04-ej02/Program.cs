
using Billetes;

namespace clase_04_ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euro billeteEuro = 1;
            Peso billetePeso = (Peso)billeteEuro;
            Dolar billetedDolar = 100;

            Console.WriteLine(billetePeso.GetCantidad);
            Console.ReadKey();
            billetePeso = (Peso)billetedDolar;
            Console.WriteLine("Dolar en pesos: {0}",billetePeso.GetCantidad);


        }
    }
}