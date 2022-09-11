using System.Runtime.CompilerServices;

namespace Temperaturas
{
    public class Fahrenheit
    {
        private double temperatura;

        public  Fahrenheit(double value)
        { 
            this.temperatura = value;
        }

        public double GetCantidad
        {
            get { return this.temperatura; }
        }


        public static explicit operator Celsius(Fahrenheit grados)
        {
            return new Celsius((grados.temperatura - 32) * 5 / 9);
        }

        public static explicit operator Kelvin(Fahrenheit grados)
        {
            return new Kelvin((grados.temperatura + 459.67) * 5 / 9);
        }

    }
}


/*
 * Consigna
Crear un proyecto de consola y un proyecto de biblioteca de clases. Agregar al último tres clases Fahrenheit, Celsius y Kelvin.

Realizar la implementación necesaria para poder convertir una temperatura en sus distintas unidades de medida (Fahrenheit, Celsius y Kelvin).

Utilizar sobrecargas de métodos, operadores y/o conversiones.

TIP
F = C * (9/5) + 32

C = (F-32) * 5/9

F = K * 9/5 – 459.67

K = (F + 459.67) * 5/9
 * 
 * 
 */