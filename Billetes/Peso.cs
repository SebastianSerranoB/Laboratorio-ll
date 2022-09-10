using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        //atributos Euro
        private double cantidad;
        private static double cotizRespectoDolar;

        //Constructores para Euro
        static Peso()
        {
            Peso.cotizRespectoDolar = 1 * 278; // 07/09/22
        }

        //Constructores accesibles, sobrecargados
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
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
            get { return Peso.cotizRespectoDolar; }
        }

        //METODO REQUERIDO EN EJ 3, WINDOWS FORMS, COTIZADOR CON FORMULARIO
        public static void SetCotizacion(double value)
        {
            value = Peso.cotizRespectoDolar;
        }

        //sobrecarga implicita de Double
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        //sobrecarga explicita para Dolar y Euro
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad / Peso.GetCotizacion); //cantidad en pesos / cotizacion de dolar para peso
        }
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);    //utilizamos conversiones explicitas; tomamos el peso, lo convertimos a dolar, y el resultado lo convertimos a euro
        }

        //generamos los comparadores y sobrecargamos operadores aritmeticos
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad == p2.GetCantidad;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }


        public static bool operator ==(Peso p, Dolar d)
        {
            return (p.GetCantidad == ((Peso)d).GetCantidad);
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return (p.cantidad == ((Peso)e).GetCantidad);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso((p.cantidad + ((Peso)d).GetCantidad));
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso((p.cantidad - ((Peso)d).GetCantidad));
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso((p.cantidad + ((Peso)e).GetCantidad));
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso((p.cantidad - ((Peso)e).GetCantidad));
        }


    }
}
