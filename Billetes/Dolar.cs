namespace Billetes
{
    public class Dolar
    {
        //atributos para Dolar
        private double cantidad;
        private static double cotizRespectoDolar;

        //Constructores para Dolar
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;   // this.cotiz.. = 1; this no se utiliza en un static, solo es accesible como  Clase.identificadorAtributo = 
        }

        //Constructores accesibles, sobrecargados
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)  //this(cantidad) , estamos llamando a el primer constructor publico, Dolar(cantidad); para no repetir codigo, simplifica
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        //encapsulamiento
        //Lo correcto es generar metodos GET, pero en este caso los reemplazaremos por  propiedades.
        public double GetCantidad
        {
            get { return this.cantidad; }
        }

        //la cotizacion es fija, le corresponde un static, no va a variar para las instancias de Dolar, en cambio la cantidad si.
        public static double GetCotizacion 
        { 
            get { return Dolar.cotizRespectoDolar; }
        }

        //sobrecarga implicita de Double
        public static implicit operator Dolar(double d) 
        {
            return new Dolar(d);
        }

        //sobrecarga explicita para Euro y Peso
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion);
        }
        public static  explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion);
        }

        //generamos los comparadores y sobrecargamos operadores aritmeticos

        //dolar == dolar
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad == d2.GetCantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
           // return d1.GetCantidad != d2.GetCantidad;
           return !(d1 == d2);  //reutilzamos la comparacion ==, que compara las cantidades
        }

        //dolar == euro
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad == ((Dolar)e).GetCantidad;  //comparamos cantidad dolar == casteo(conversion explicita euro a dolar.cantidad
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        //dolar == peso

        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.cantidad == ((Dolar)p).GetCantidad);  //el parentesis es prolijo (casteo de  peso a dolar y getter cantidad  --((Dolar)p.GetCantidad))  != ((Dolar)p).GetCantidad) ojo con los parenteis
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        //dolar +- Euro/peso
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar((d.cantidad + ((Dolar)e).GetCantidad));
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar( (d.cantidad - ((Dolar)e).GetCantidad));
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar((d.cantidad + ((Dolar)p).GetCantidad));  //el parentesis es prolijo (casteo de  peso a dolar y getter cantidad  --((Dolar)p.GetCantidad))  != ((Dolar)p).GetCantidad) ojo con los parenteis
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar((d.cantidad - ((Dolar)p).GetCantidad));
        }


    }
}