using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosTerrestres
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short cilindrada, short cantidadRuedas, short cantidadPuertas, eColores eColor) : base(cantidadRuedas, cantidadPuertas, eColor)
        {
            this.cilindrada = cilindrada;
        }


    }
}

/*
 * Camion tendrá los atributos: cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
Automovil tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, cantidadPasajeros : int.
Moto tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
Crearle a cada clase un constructor que reciba todos sus atributos.

comunes:
cantidadRuedas short
cantidadPuertas short
ecolor eColores
 */