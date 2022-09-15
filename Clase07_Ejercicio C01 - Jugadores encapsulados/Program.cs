using EstadisticaDeportiva;

namespace Clase07_Ejercicio_C01___Jugadores_encapsulados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2, "utn");
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);


            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO AL EQUIPO " + j3.MostrarDatos()); //JUGADOR REPETIDO

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO AL EQUIPO " + j4.MostrarDatos());  ///CAPACIDAD EQUIPO SOBREpasada

        }
    }
}