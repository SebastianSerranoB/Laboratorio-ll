using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Carreras
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
           competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        { 
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }


        public void MostrarDatos() //figuraba como retorna string, pero voy a hacer que muestre todos los competidores
        { 
            StringBuilder sb = new StringBuilder();

            Console.WriteLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            Console.WriteLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            if (this.competidores.Count > 0)
            {
                Console.WriteLine("--Lista de competidores--");
                foreach (AutoF1 competidor in this.competidores)
                {
                    Console.WriteLine(competidor.MostrarDatos());
                }
            }
            else
            { Console.WriteLine("No se registran competidores."); }

        }







        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            
            if (c is not null && a is not null && c.competidores.Count > 0)
            {
                if (c.competidores.Contains(a))
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

       
        public static Competencia operator +(Competencia c, AutoF1 a)
        {
            Competencia retorno = c;
            if (c is not null && a is not null)
            {
               // Console.WriteLine($"competidores + 1 = {c.competidores.Count} ");
                if (c.competidores.Count < c.cantidadCompetidores && c != a)
                {

                    Random rand = new Random();

                    c.competidores.Add(a);
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.CantidadCombustible = (short)rand.Next(15, 100);
                    a.EnCompetencia = true;

                    Console.WriteLine("Se añadio un piloto a la competencia...");
                    return c;
                }
               
                Console.WriteLine("No se añadieron pilotos a la competencia...");
            }


            return retorno;
        }

        public static Competencia operator -(Competencia c, AutoF1 a)
        {
            Competencia retorno = c;
            if (c is not null && a is not null && c.cantidadCompetidores > 0)
            {
                if (c == a)
                {
                    c.competidores.Remove(a);
                    Console.WriteLine("Se elimino un piloto de la competencia...");
                    return c;
                }
            }
            Console.WriteLine("Ningun piloto fue eliminado...");

            return retorno;
        }



    }
}




 