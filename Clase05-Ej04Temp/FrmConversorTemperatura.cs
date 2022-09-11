using Temperaturas;

namespace Clase05_Ej04Temp
{
    public partial class FrmConversorTemperatura : Form
    {
        public FrmConversorTemperatura()
        {
            InitializeComponent();
        }

        private void btnConversorFahrenheit_Click(object sender, EventArgs e)
        {
            Fahrenheit temperaturaFahrenheit;
            //Corresponde validar que la lectura del textbox no sea null o empty y volver al foco del textbox
            temperaturaFahrenheit = new Fahrenheit(double.Parse(this.txtBoxFahrenheitGrados.Text));

            txtBoxFahrenheitAFahrenheit.Text = temperaturaFahrenheit.GetCantidad.ToString("N2"); ;
            txtBoxFahrenheitACelsius.Text = ((Celsius)temperaturaFahrenheit).GetCantidad.ToString("N2");
            txtBoxFahrenheitAKelvin.Text = ((Kelvin)temperaturaFahrenheit).GetCantidad.ToString("N2");

        }

        private void btnConversorCelsius_Click(object sender, EventArgs e)
        {
            Celsius temperaturaCelsius;
            temperaturaCelsius = new Celsius(double.Parse(this.txtBoxCelsiusGrados.Text));
            //corresponde validar el textbox
            txtBoxCelsiusACelsius.Text = temperaturaCelsius.GetCantidad.ToString("N2");
            txtBoxCelsiusAFahrenheit.Text = ((Fahrenheit)temperaturaCelsius).GetCantidad.ToString("N2");
            txtBoxCelsiusAKelvin.Text = ((Kelvin)temperaturaCelsius).GetCantidad.ToString("N2"); ;

        }

        private void btnConversorKelvin_Click(object sender, EventArgs e)
        {
            Kelvin temperaturaKelvin;
            temperaturaKelvin = new Kelvin(double.Parse(this.txtBoxKelvinGrados.Text));
            //corresponde validar el textbox

            txtBoxKelvinAKelvin.Text = temperaturaKelvin.GetCantidad.ToString("N2");
            txtBoxKelvinAFahrenheit.Text = ((Fahrenheit)temperaturaKelvin).GetCantidad.ToString("N2");
            txtBoxKelvinACelsius.Text = ((Celsius)temperaturaKelvin).GetCantidad.ToString("N2");


        }
    }
}