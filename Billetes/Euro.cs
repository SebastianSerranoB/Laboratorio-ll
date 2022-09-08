using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        //atributos Euro
        private double cantidad;
        private static double cotizRespectoDolar;

        //Constructores para Euro
        static Euro()
        {
            Euro.cotizRespectoDolar = 1 / 1.17;   //esta abajo para 07/09 pero dejamos asi
        }

        //Constructores accesibles, sobrecargados
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        //encapsulamiento
        //Lo correcto es generar metodos GET, pero en este caso los reemplazaremos por  propiedades.
        public double GetCantidad
        {
            get { return this.cantidad; }
        }

        //la cotizacion es fija, le corresponde un static, no va a variar para las instancias de , en cambio la cantidad si.
        public static double GetCotizacion
        {
            get { return Euro.cotizRespectoDolar; }
        }

        //sobrecarga implicita de Double
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        //sobrecarga explicita para Dolar y Peso
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion);
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);    //utilizamos conversiones explicitas
        }

       
        
        //generamos los comparadores y sobrecargamos operadores aritmeticos
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad == e2.GetCantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
           
            return !(e1 == e2);  
        }

       
        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.GetCantidad == ((Euro)d).GetCantidad);  
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return (e.cantidad == ((Euro)p).GetCantidad);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro((e.cantidad + ((Euro)d).GetCantidad));
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro((e.cantidad - ((Euro)d).GetCantidad));
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro((e.cantidad + ((Euro)p).GetCantidad));  
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro((e.cantidad - ((Dolar)p).GetCantidad));
        }


    }
}
