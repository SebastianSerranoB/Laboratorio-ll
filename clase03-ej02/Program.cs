using clase03_ej02;

Persona p1 = new Persona("Sebastian Serrano", "07/11/2000", "42.810.404");
Persona p2 = new Persona("Gabriela Rodruigez", "07/05/1983", "31.200.334");
Persona p3 = new Persona("Olivia Valeares", "16/01/2010", "20.510.222");
//Persona[] p = new Persona[] { p1, p2 };


Console.WriteLine("{0};  {1}; ", p1.Mostrar(), p1.EsMayorDeEdad());
Console.WriteLine("{0};  {1}; ", p2.Mostrar(), p2.EsMayorDeEdad());
Console.WriteLine("{0};  {1}; ", p3.Mostrar(), p3.EsMayorDeEdad());



//try catch para errores de ingreso de fecha, dni nombre


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
