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
                //  return this.clientes.First();       //deberia retornar el indice 1 o el 0 ?
                return this.clientes.Peek();
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
            if (n.clientes.Count() > 0  &&  n is not null) //como evito el null?
            {
                n.caja.Atender(n.clientes.Dequeue());
                return true;
            }
           
            return false;
        }
      
       

    }
}
