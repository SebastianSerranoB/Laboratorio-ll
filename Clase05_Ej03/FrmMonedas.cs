using Billetes;
using System.Runtime.CompilerServices;

namespace Clase05_Ej03
{
    public partial class FrmMonedas : Form
    {
        private int indiceLock;
        public FrmMonedas()
        {
            InitializeComponent();
            indiceLock = 0;
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            indiceLock++; 
          
            if (indiceLock > 1)
            {
                indiceLock = 0;
            }
            btnCandado.ImageIndex = indiceLock;  //0 == UNLOCKED || 1 == LOCKED

            if (indiceLock == 0)
            {
                this.txtBoxCotizEuro.Enabled = true;
                this.txtBoxCotizDolar.Enabled = true;
                this.txtBoxCotizPeso.Enabled = true;
            }
            else
            {
                this.txtBoxCotizEuro.Enabled = false;
                this.txtBoxCotizDolar.Enabled = false;
                this.txtBoxCotizPeso.Enabled = false;

            }

        }

        //buscamos en los eventos de textbox y hacemos dobleClick para generar el handler del evento
        //quizas lo correcto es verificar null o empty desde el boton locked, para mejor manejo del focus
        private void txtBoxCotizEuro_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBoxCotizEuro.Text))
            {
                Euro.SetCotizacion(double.Parse(this.txtBoxCotizEuro.Text));
            }
            else
            {
                txtBoxCotizEuro.Focus();
            }  
        }

        private void txtBoxCotizDolar_Leave(object sender, EventArgs e)
        {
            //el dolar siempre queda en 1, no entiendo porque deberia poder modificarse?¿
            this.txtBoxCotizDolar.Text = "1";
        }

        private void txtBoxCotizPeso_Leave(object sender, EventArgs e)
        {
            //quizas lo correcto es verificar null o empty desde el boton locked, para mejor manejo del focus
            if (!string.IsNullOrEmpty(this.txtBoxCotizPeso.Text))
            {
                Peso.SetCotizacion(double.Parse(this.txtBoxCotizPeso.Text));
            }
            else
            {
                txtBoxCotizPeso.Focus();
            } 
        }

        private void btnConversorEuro_Click(object sender, EventArgs e)
        {
            //corresponde validar, null/empty en los textbox de cantidad y que sean mayor a 0, tambien que esten los valores de cotizacion aunque el evento leave se encargaria de eso, creo que corresponde chequearlo aca tambien
          //los atributos son privados aqui?
            Euro BilleteEuro = int.Parse(this.txtBoxCantidadEuro.Text);
           Peso BilletePeso = (Peso)BilleteEuro;
           Dolar BilleteDolar = (Dolar)BilleteEuro;

            //El parametro N2 modifca la cantidad de decimales que muestro
            txtBoxEuroAEuro.Text =  BilleteEuro.GetCantidad.ToString("N2");
            txtBoxEuroADolar.Text = BilleteDolar.GetCantidad.ToString("N2");
            txtBoxEuroAPeso.Text = BilletePeso.GetCantidad.ToString("N2");
        }

        private void btnConversorDolar_Click(object sender, EventArgs e)
        {
             Dolar billeteDolar = int.Parse(this.txtBoxCantidadDolar.Text);
             Euro billeteEuro = (Euro)billeteDolar;
             Peso billetePeso = (Peso)billeteDolar;

            txtBoxDolarADolar.Text = billeteDolar.GetCantidad.ToString("N2");
            txtBoxDolarAEuro.Text = billeteEuro.GetCantidad.ToString("N2");
            txtBoxDolarAPeso.Text = billetePeso.GetCantidad.ToString("N2");
          
        }

        private void btnConversorPeso_Click(object sender, EventArgs e)
        {
            Peso billeteDePeso = int.Parse(this.txtBoxCantidadPeso.Text);
            Euro billeteDeEuro = (Euro)billeteDePeso;
            Dolar billeteDeDolar = (Dolar)billeteDePeso;

            txtBoxPesoAPeso.Text = billeteDePeso.GetCantidad.ToString("N2");
            txtBoxPesoAEuro.Text = billeteDeEuro.GetCantidad.ToString("N2");
            txtBoxPesoADolar.Text = billeteDeDolar.GetCantidad.ToString("N2");


        }
    }
}