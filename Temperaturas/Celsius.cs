using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Celsius
    {
        private double temperatura;

        public Celsius(double value)
        {
            this.temperatura = value;
        }
        public double GetCantidad
        {
            get { return this.temperatura; }
        }

        public static explicit operator Fahrenheit(Celsius grados)
        {
            return new Fahrenheit((grados.temperatura * (9 / 5)) + 32);
        }

        public static explicit operator Kelvin(Celsius grados)
        {
            return new Kelvin(grados.temperatura + 273.15);
        }
     
    }
}
/*TIP
F = C * (9 / 5) + 32

C = (F-32) *5 / 9

F = K * 9 / 5 – 459.67

K = (F + 459.67) * 5 / 9*/