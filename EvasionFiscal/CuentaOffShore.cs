using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvasionFiscal
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta; //falta un getter para mostrar por consola este elemnto, no figura en el diagrama pero lo hice
        private double _saldo;

        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            _dueño = dueño;
            _numeroCuenta = numero;
            _saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre, eTipoCliente tipoCliente, int numero, double saldoInicial) 
            : this(new Cliente(tipoCliente,nombre), numero, saldoInicial)
        {
        }

        public Cliente Dueño
        {
            get {
                return this._dueño;
            }
        }

        public double Saldo
        {
            get
            {
                return this._saldo;
            }

            set
            {
                if (value > -1)
                {
                    this._saldo = value;
                }
            }
        }

        //no figura en el diagrama pero si se muestra por consola, requiere un get para acceder al atrib private
        public int NumeroCuenta
        {
            get 
            {
                return this._numeroCuenta;
            }
        }


        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return  (cos1._numeroCuenta == cos2._numeroCuenta) && ( cos1.Dueño.GetAlias() == cos2.Dueño.GetAlias() ) ;
        }
        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2) ;
        }

        public static explicit operator int(CuentaOffShore cos)
        { 
            return cos._numeroCuenta;
        }


    }
}
