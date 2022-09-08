using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
 */

//cEjercicio I02 - ¿Desea continuar?
//Consigna
//Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

//Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

//El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

//Resolución

namespace Clase_02_Ej01
{

    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            //bool retorno = false;
            //if (valor >= min && valor <= max)
            //{
            //    retorno = true;
            //}
            //return retorno;
            return valor >= min && valor <= max;
        }
        
        public static bool ValidarRespuesta(char respuesta) 
        {
            return Char.ToUpper(respuesta) == 'S';
        }

    }
}
