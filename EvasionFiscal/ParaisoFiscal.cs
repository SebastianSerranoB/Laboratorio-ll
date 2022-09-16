using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvasionFiscal
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        static int cantidadDeCuentas;
        static DateTime fechaInicioActividades;


        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadDeCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugar) : this()
        {
            this._lugar = lugar;
        }

        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n|-- PARAISO FISCAL --|");
            sb.AppendLine($"Lugar: {this._lugar}");
            sb.AppendLine($"Inicio de actividades: {ParaisoFiscal.fechaInicioActividades}");
            sb.AppendLine($"Cantidad de cuentas: {ParaisoFiscal.cantidadDeCuentas}");
            if (this._listadoCuentas.Count > 0)
            {
                sb.AppendLine("\n|-- DETALLE DE CUENTAS --|");

                foreach (CuentaOffShore cos in this._listadoCuentas)
                {  
                    sb.AppendLine($"\nDueño: {Cliente.RetornarDatos(cos.Dueño)}");
                    sb.AppendLine($"Numero de cuenta: {cos.NumeroCuenta}"); 
                    sb.AppendLine($"Saldo: {cos.Saldo} ");
                }

            }

            Console.WriteLine(sb.ToString());
        }

        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }
        


        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return pf._listadoCuentas.Contains(cos);
        }
        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            ParaisoFiscal retornoParaiso = pf;

            if (pf is not null && pf._listadoCuentas.Count > 0 && cos is not null)
            {
                if (pf._listadoCuentas.Contains(cos))
                {
                    pf._listadoCuentas.Remove(cos);
                    ParaisoFiscal.cantidadDeCuentas--;
                    Console.WriteLine("Se quito la cuenta del paraiso...");
                }
                else
                {
                    Console.WriteLine("La cuenta no existe en el paraiso...");
                }
               
                return pf;
            }

            return retornoParaiso;
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            ParaisoFiscal retornoParaiso = pf;
            bool flagExiste = false;
            
            if (pf is not null && pf._listadoCuentas.Count > -1 && cos is not null)
            {
                foreach (CuentaOffShore cuenta in pf._listadoCuentas)
                {
                    if (cuenta == cos)
                    {
                        flagExiste = true;
                        cuenta.Saldo += cos.Saldo;
                        Console.WriteLine("Se actualizó el saldo de la cuenta...");
                    }
                }

                if (!flagExiste)
                {
                    pf._listadoCuentas.Add(cos);
                    ParaisoFiscal.cantidadDeCuentas++;
                    Console.WriteLine("Se agrego la cuenta al paraiso...");
                }

                return pf;

            }

            return retornoParaiso;
        }

       
         
         
        



    }

}
