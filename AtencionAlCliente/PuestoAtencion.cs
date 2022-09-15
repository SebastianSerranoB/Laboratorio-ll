using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class PuestoAtencion
    {
        #region Atributos
        private static int numeroActual;
        private Puesto puesto;
        #endregion

        #region Constructores

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        #endregion

        #region Propiedades
        public static int NumeroActual()
        {
            PuestoAtencion.numeroActual++;
            return PuestoAtencion.numeroActual;
        }
        #endregion
       
        
        #region Metodos

        public bool Atender(Cliente c1)
        {
            Thread.Sleep(1000);
            return true;
        }
        #endregion
    }
}
