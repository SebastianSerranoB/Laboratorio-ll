using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace clase03_ej02
{
    internal class Persona
    {

        private string _nombre = string.Empty,
            _fechaDeNacimiento = string.Empty,
            _dni = string.Empty;

        public Persona(string nombre, string fechaDeNacimiento, string dni)
        {
            this._nombre = nombre;
            this._fechaDeNacimiento = fechaDeNacimiento;
            this._dni = dni;
        }

        public void SetNombre(string nombre) {
            if (!string.IsNullOrEmpty(nombre)) {
                this._nombre = nombre;
            }
            else {
                Console.WriteLine("Error, NULL o EMPTY.");
            }
           
        }
        public string GetNombre() { return this._nombre;}

        public void SetFechaDeNacimiento(string FechadeNacimiento)
        {
            if (!string.IsNullOrEmpty(FechadeNacimiento))
            {
                this._fechaDeNacimiento = FechadeNacimiento;
            }
            else
            {
                Console.WriteLine("Error, NULL o EMPTY.");
            }

        }
        public string GetFechaDeNacimiento() { return this._fechaDeNacimiento;}

        public void SetDni(string dni)
        {
            if (!string.IsNullOrEmpty(dni))
            {
                this._dni = dni;
            }
            else
            {
                Console.WriteLine("Error, NULL o EMPTY.");
            }

        }
        public string GetDni() { return this._dni;}

        //corresponden mas validaciones, para el constructor y setters de los atributos.


        //lo  mas preciso seria calcular los dias, por ejemplo, hoy es 06/09/22 y figura como que tengo 22 años, 
        private double CalcularEdad()
        {  
            DateTime fechaActual = DateTime.Now;
            DateTime fechaDeNacimiento = DateTime.ParseExact( this._fechaDeNacimiento, "dd/MM/yyyy", null);
            TimeSpan diferencia = fechaActual - fechaDeNacimiento;
            double dias = diferencia.TotalDays;
            double años = Math.Floor(dias / 365);
            

            return años;
        }
       
        public string Mostrar()
        {
            return "-DATOS PERSONA-\nNombre: " + this._nombre + "\nDNI: " + this._dni + "\nFecha de nacimiento: " + this._fechaDeNacimiento + "\tEdad: " + CalcularEdad();
        }

        public string EsMayorDeEdad()
        {
            double edad = CalcularEdad();
            if(edad > 17)
            {
                return "Es mayor de edad.";
            }
            else
            {
                return "Es menor de edad.";
            }
        }


        
        //CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
        //Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
        //EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
        //Instanciar 3 objetos de tipo Persona en el método Main.
        //Mostrar quiénes son mayores de edad y quiénes no.

    }
}

//Ejercicio I02 - ¿Vos cuántas primaveras tenés?
//Consigna
//Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

//Deberá tener los atributos:

//nombre
//fechaDeNacimiento
//dni
//Deberá tener un constructor que inicialice todos los atributos.

//Construir los siguientes métodos para la clase:

//Setter y getter para cada uno de los atributos.
//CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
//Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
//EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
//Instanciar 3 objetos de tipo Persona en el método Main.
//Mostrar quiénes son mayores de edad y quiénes no.
