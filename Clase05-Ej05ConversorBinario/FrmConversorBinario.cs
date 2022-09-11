
using clase02_ej03;
namespace Clase05_Ej05ConversorBinario
{
    public partial class FrmConversorBinario : Form
    {
        public FrmConversorBinario()
        {
            InitializeComponent();
           
        }

        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            //corresponde validar el textbox
            this.txtBoxBinADecimalResultado.Text = Conversor.ConvertirBinarioADecimal(int.Parse(this.txtBoxNumBinario.Text)).ToString();
        }

        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            //corresponde validar el textbox
            this.txtBoxDecABinResultado.Text = Conversor.ConvertirDecimalABinario(int.Parse(this.txtBoxNumDecimal.Text)).ToString();
        }
    }
}