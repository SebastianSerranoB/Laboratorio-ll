using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Kelvin
    {
        private double temperatura;

        public Kelvin(double value)
        {
            this.temperatura = value;
        }
        public double GetCantidad
        {
            get { return this.temperatura; }
        }

        public static explicit operator Fahrenheit(Kelvin grados)
        {
            return new Fahrenheit((grados.temperatura * (9 / 5)) - 459.67);
        }

        public static explicit operator Celsius(Kelvin grados)
        {
            return new Celsius(grados.temperatura - 273.15);
        }
    
    }
}
/*TIP
F = C * (9 / 5) + 32

C = (F-32) *5 / 9

F = K * 9 / 5 – 459.67

K = (F + 459.67) * 5 / 9*/








    

