using Carreras;

namespace Clase07_Ejercicio_C02___Enciendan_sus_motores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sebastian Serrano || -Enciendan sus motores-";
            AutoF1 auto1 = new AutoF1(5, "Ferrari");
            AutoF1 auto2 = new AutoF1(20, "Mercedes");
            AutoF1 auto3 = new AutoF1(33, "McLaren");
            
            Competencia formula1 = new Competencia(20, 20);

            Console.WriteLine($"Auto 1: {auto1.MostrarDatos()}"); //No esta compitiendo
            Console.WriteLine($"Auto 2: {auto2.MostrarDatos()}"); //--
            Console.WriteLine($"Auto 3: {auto3.MostrarDatos()}"); // --
            formula1.MostrarDatos(); //20 - 20 - no se registran competidores

            ////////////////////////////////////////////////

            formula1 += auto1;
            formula1 += auto2;
            formula1 += auto3;

            formula1.MostrarDatos(); 
            
            //////////////////////////////////////////
            formula1 -= auto1;
            formula1 -= auto2;

            formula1.MostrarDatos();

            /////////////////////////
            Competencia formula2 = new Competencia(5, 2);
            formula2 += auto3;
            formula2 += auto2;
            formula2 += auto1; //auto1 ferrari no entra, maximo competidores lleno
           
            formula2.MostrarDatos();

  

            Console.ReadLine();
        }
    }
}