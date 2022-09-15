namespace AtencionAlCliente
{
    public class Cliente
    {
        #region Atributos
        private string nombre;
        private int numero;
        #endregion


        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set 
            {
                this.nombre = value; //parametro implicito , accede por asginacion '='.
            }
        
        }

        public int Numero
        { 
            get { return this.numero; }
        }

        #endregion


        #region Constructores
        public Cliente(int numero)
        { 
            this.numero = numero;
            this.nombre = "Anonimo";
        }
        public Cliente(int numero, string nombre)
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        #endregion


        #region Metodos

        public static bool operator ==(Cliente c1, Cliente c2)
        {   
            return c1.numero == c2.numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
        #endregion
    }
}