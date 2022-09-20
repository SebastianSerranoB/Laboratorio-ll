namespace Clase07_Ejercicio_I02__Consultaste_el_índice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro nuevoLibro = new Libro("Mi primer libro");

            Console.WriteLine("Primer pagina: " + nuevoLibro[0]);
            nuevoLibro[-1] = "No existe la pagina -1";
            Console.WriteLine("Existe la pagina -1?:  " + nuevoLibro[-1]);
            Console.WriteLine("No existe la pagina 5 : "  + nuevoLibro[5]);
            nuevoLibro[5] = "Ahora si existe la pagina 5 ";

            Console.WriteLine("Existe la 1, pero existe la 5? -> " + nuevoLibro[5]);
            for (int i = 1; i < 5; i++)
            {
                nuevoLibro[i] = "pagina " + i;
            }
            Console.WriteLine("y ahora? (despues del for) -> " + nuevoLibro[5]);

            ////foreach (string pagina in nuevoLibro.paginas) // el atributo en public
            ////{
            ////    Console.WriteLine(pagina);
            ////}

            //faltaria un getter para la list paginas

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(nuevoLibro[i]);  
            }

        }
    }
}