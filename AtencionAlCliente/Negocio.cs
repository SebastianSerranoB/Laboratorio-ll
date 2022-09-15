using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string? nombre;

        //porque el constructor es private y no es stacic, que diferencias tienen ?
        //el static se ejectua por defecto cuando instanciamos una clase, el privado no ?
       
       
        private Negocio()
        {
            //Puesto puesto = new Puesto();
            // this.caja = new PuestoAtencion(new Puesto());
            this.caja = new PuestoAtencion(Puesto.caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
         
        }

        public Cliente Cliente
        {
            get
            {
                  return this.clientes.First();       //deberia retornar el indice 1 o el 0 ?
              // return this.clientes.ElementAt(0); //permite especificar el indice
            }
            set 
            {
                //es valido contains en este caso o deberia recorrer un foreach del queue preguntando si cliente == cliente?
                //Contains validara que la referencia no sea la misma, no si el numero de cliente es el mismo

                //if (!(this.clientes.Contains(value)))
                //{
                //    this.clientes.Enqueue(value);
                //}
                //else
                //{
                //    Console.WriteLine("El cliente ya se encuentra en la cola.");
                //}
                bool flag = false;  
                foreach (Cliente cliente in this.clientes)
                {
                    if (cliente == value)
                    {
                        flag = true;
                        Console.WriteLine("El cliente ya se encuentra en la cola.");
                        break;
                    }
                }
               
                if (!flag)
                {
                    this.clientes.Enqueue(value);
                }

            }
        
        }

        public int ClientesPendientes()
        {
            return this.clientes.Count();  
        }



        public static bool operator ==(Negocio n, Cliente c)
        {
            //  return n.clientes.Contains(c);    //deberia verificar numero de cliente? pueden ser distintas variables pero compartir numero
             bool retorno = false;

            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
          
            if (n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
               
            return retorno;
        }

        public static bool operator ~(Negocio n)
        {

           // CS0120; Se requiere una referencia de objeto para el campo, metodo o propiedad negocio.caja // negocio.Cliente no estaticos
            return Negocio.caja.Atender(Negocio.Cliente); //como Deberia funcionar esta linea?
            //no puede acceder al atributo de la clase porque es estatico, deberia hacer los atributos estaticos? 
        //    No puede acceder a los atributos de la clase(salvo que sean estáticos)
        //No puede utilizar el operador this, ya que este método se puede llamar sin tener que crear un objeto de la clase.
        //Puede llamar a otro método siempre y cuando sea estático.
        //Un método estático es lo más parecido a lo que son las funciones en los lenguajes estructurados
        //        (con la diferencia que se encuentra encapsulado en una clase)
        }
       // El operador ~generará una atención del próximo cliente en la cola, 
        //  utilizando la propiedad Cliente y el método Atender de PuestoAtencion.Retornará true si pudo realizar la operación completa.


    }
}
