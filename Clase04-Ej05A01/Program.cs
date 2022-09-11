using Temperaturas;

namespace Clase04_Ej05A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit temperaturaFahrenheit = new Fahrenheit(20);
            Celsius temperaturaCelsius = (Celsius)temperaturaFahrenheit;
            Kelvin temperaturaKelvin = (Kelvin)temperaturaCelsius;

            Console.WriteLine($"{temperaturaFahrenheit.GetCantidad}"); //20
            Console.WriteLine($"{temperaturaCelsius.GetCantidad}");  ///-6
            Console.WriteLine($"{temperaturaKelvin.GetCantidad}");  // 267

        }
    }
}