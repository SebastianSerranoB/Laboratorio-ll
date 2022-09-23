using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadoresEncapsulados_Herencia
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) :base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public DateTime FechaNacimiento
        {
            get 
            {
                return this.fechaNacimiento;
            }
            
            set 
            { 
               fechaNacimiento= value;
            }
        
        }

        //Como reutilizamos el metodo de la clase padre agregandole una funcionanalidad?
        //Declaramos un nuevo metodo MostrarDatos
        //la otra forma es cambiarle el nombre al metood
        //Pero, la forma que vamos a utilizar es override y virtual , forma de reutilziar similar a sobrecargar metodos y otras cosa, tiene que ver con polimorfismo
        public new string MostrarDatos() 
        {
            
           return base.MostrarDatos() + "\nFecha de nacimiento: " + this.fechaNacimiento.ToString();
        }

        //virtual override
        //public override string MostrarDatos(){}



        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if (dt1 is not null && dt2 is not null)
            {
                return (  (dt1.Nombre == dt2.Nombre)  &&  (dt1.FechaNacimiento == dt1.FechaNacimiento)  ) ;
            }

            return false;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        { 
            return !(dt1 == dt2);
        }




    }
}
