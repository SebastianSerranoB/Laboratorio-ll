using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase03_ej01
{
    internal class Cuenta
    {
        //consultar: "_identificador" de atributo; lei que es una convencion para los atributos a los que se accede con get/set
        private string _titular = string.Empty;
        private float _cantidad;

        //constructor parametrizado
        public Cuenta(string titular, float cantidad)
        {
            this._titular = titular;
            this._cantidad = cantidad;
        }

        //public void CuentaAux(string titular2) 
        //{
        //    if (!string.IsNullOrEmpty(titular2))
        //    {
        //       //seteo el el titular, simplemente validar que no ingrese null o vacio, tambien corresponderia alguna validacion mas para una razon social
        //    }
        //}

        //getter/setter para atributos, siempre son publicos, a  traves de ellos, accedemos a los atributos privados de una clase con una capa mas de abstraccion y seguridad
        //ya que podemos validar que es lo que se guarda en un atributo(setter), tambien podriamos hacer validaciones para get pero seria raro

        //en este caso, el ejercicio no requeria setters, pero es muy puntual.
        public string GetTitular { get { return _titular; } }
        public float GetCantidad { get { return _cantidad; } }

        //metodos

        public string Mostrar()
        {
            return "titular: " + this._titular + "\ncantidad: " +  this._cantidad;
        }

        public void Ingresar(float deposito)
        {
            if (deposito > 0)
            {
                this._cantidad += deposito;
            }
            else {
                Console.WriteLine("Un deposito negativo no tiene efecto.");
            }
        }

        public float Retirar(float extraccion) 
        {
            if (extraccion > 0)
            {
                this._cantidad -= extraccion;
            }
            else {
                Console.WriteLine("Una extraccion negativa no tiene efecto.");
            }

            return extraccion;
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