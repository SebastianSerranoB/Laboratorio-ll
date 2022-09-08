namespace clase03_ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1;
            string?  razonSocial;  // el "?" permite que sea null, no creo que sea lo mas prolijo en este caso 
            float saldoInicial;
            float monto;  //selecciona el nombre de la variable, crtl+r puedo cambiar el nombre de todas las que compartian ese identificador.
            bool flag;


            Console.WriteLine("Ingrese la razon social de la cuenta nueva: ");
             razonSocial =  Console.ReadLine();
            while(string.IsNullOrEmpty(razonSocial))
            {
                Console.WriteLine("Error! Reingrese la razon social de la cuenta nueva: ");
                razonSocial = Console.ReadLine();
            }
           
            Console.WriteLine("Ingrese el saldo inicial de la cuenta nueva: ");
            flag = float.TryParse(Console.ReadLine(), out saldoInicial);
            while (!flag) 
            {
                Console.WriteLine("Error! Ingrese el saldo inicial de la cuenta nueva: ");
                flag = float.TryParse(Console.ReadLine(), out saldoInicial);
            }

            c1 = new Cuenta(razonSocial, saldoInicial);

            Console.WriteLine("La cuenta nueva:\n{0}", c1.Mostrar());
           

            Console.WriteLine("Ingrese el monto a depositar: ");
            flag = float.TryParse(Console.ReadLine(), out monto);
            while (!flag)
            {
                Console.WriteLine("Error! Ingrese el deposito: ");
                flag = float.TryParse(Console.ReadLine(), out monto);
            }
            c1.Ingresar(monto);
            Console.WriteLine("Deposito: \n{0}", c1.Mostrar());
           

            Console.WriteLine("Ingrese el monto a retirar: ");
            flag = float.TryParse(Console.ReadLine(), out monto);
            while (!flag)
            {
                Console.WriteLine("Error! Ingrese el monto: ");
                flag = float.TryParse(Console.ReadLine(), out monto);
            }
            c1.Retirar(monto);
            Console.WriteLine("Extraccion: \n{0}", c1.Mostrar());
            


            Console.WriteLine("-Probando los getters-\n razon social: {0}; saldo: {1}",c1.GetTitular, c1.GetCantidad);

        }
    }
}

//Ejercicio I01 - Creo que necesito un préstamo
//Consigna
//Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

//Deberá tener los atributos:

//titular que contendrá la razón social del titular de la cuenta.
//cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
//Construir los siguientes métodos para la clase:

//Un constructor que permita inicializar todos los atributos.
//Un método getter para cada atributo.
//mostrar retornará una cadena de texto con todos los datos de la cuenta.
//ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
//retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
//En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.