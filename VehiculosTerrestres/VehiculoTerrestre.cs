namespace VehiculosTerrestres
{
    public class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public eColores eColor;


        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, eColores eColor)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.eColor = eColor;
        }


    }
}

/*     Crear un proyecto de biblioteca de clases con las clases Automovil, Moto, Camion.

Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }

Camion tendrá los atributos: cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
Automovil tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, cantidadPasajeros : int.
Moto tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
Crearle a cada clase un constructor que reciba todos sus atributos.

comunes:
cantidadRuedas short
cantidadPuertas short
ecolor eColores


//que pasa con cantidad marchas? si bien tendria sentido que sea un atributo de la clase padre vehiculo terrestre, esta olbigado en el constructor por lo que moto no podria utilixzarl,
esto debe ser un error, 

Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores. Luego generar una relación de herencia entre ellas, según corresponda.
VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las clases que heredan de ésta para que lo reutilicen.
Crear un proyecto de consola y generar el código necesario para probar las clases.

 */