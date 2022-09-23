using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoviles
{
    public class Camion
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private short cantidadMarchas;
        private int pesoCarga;
        private eColores eColor;

        public Camion(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, int pesoCarga, eColores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
            this.eColor = color;
        }

        //Camion tendrá los atributos: cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.

    }
}

/*
        Ejercicio I01 - El viajar es un placer
Consigna
Crear un proyecto de biblioteca de clases con las clases Automovil, Moto, Camion.

Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }
Camion tendrá los atributos: cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
Automovil tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, cantidadPasajeros : int.
Moto tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.



Crearle a cada clase un constructor que reciba todos sus atributos.
Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores. Luego generar una relación de herencia entre ellas, según corresponda.
VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las clases que heredan de ésta para que lo reutilicen.
Crear un proyecto de consola y generar el código necesario para probar las clases. 
 */