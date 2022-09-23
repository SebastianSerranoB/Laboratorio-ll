using System.Drawing;
using VehiculosTerrestres;

namespace Clase08_Ejercicio_I01___El_viajar_es_un_placer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Camion camioncito = new Camion(5000, 2, 8, 2, eColores.Azul);
            Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", camioncito.cantidadRuedas, camioncito.cantidadPuertas, camioncito.eColor, camioncito.cantidadMarchas, camioncito.pesoCarga);
            Console.WriteLine("--------------");
            
            Automovil autito = new Automovil(5, 5, 3, 4, eColores.Blanco);
            Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.cantidadRuedas, autito.cantidadPuertas, autito.eColor, autito.cantidadMarchas, autito.cantidadPasajeros);
            Console.WriteLine("-----------");

            Moto motito = new Moto(1000, 2, 0, eColores.Rojo);
            Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.cantidadRuedas, motito.cantidadPuertas, motito.eColor, motito.cilindrada);
        }
    }
}