using System;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Text;

namespace EvasionFiscal
{
    public class Cliente
    {
        private string? _aliasParaIncognito;
        private string? _nombre;
        private eTipoCliente tipoDeCliente;


        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
           tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente) : this()
        { 
            this.tipoDeCliente=tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente) 
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        { 
            Random numRandom = new Random();
            this._aliasParaIncognito = numRandom.Next(1000, 9000) + this.tipoDeCliente.ToString();    
        }

        public string? GetAlias()
        {
            string aliasGenerico = "Sin alias";
            bool result = aliasGenerico.Equals(this._aliasParaIncognito);

            if (result)
            {
                this.CrearAlias();
            }
         
            return this._aliasParaIncognito;
        }


        private string RetornarDatos()
        {
           StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this._nombre}");
            sb.AppendLine($"Tipo de cliente: {this.tipoDeCliente}");
            sb.Append($"Alias: {this.GetAlias()}");  
            

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente unCliente)
        {
            if (unCliente is not null)
            {
                return unCliente.RetornarDatos();
            }
            else
            {
                return "Cliente NULL";
            }

        }


    }
}