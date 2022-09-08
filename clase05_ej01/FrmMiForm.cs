namespace clase05_ej01
{
    public partial class FrmMiForm : Form
    {
        public FrmMiForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



          //objeto textBox1 accedo a Text esta declarado en designer
             //conviene acceder con this para aclarar que estamos accedeciendo desde la misma clase//si biene estan separrados los elementos, son de la misma clase

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.textBox1.Text;
            
            if ( string.IsNullOrEmpty(nombre) )
            {
                MessageBox.Show("Ha ocurrido un Error!" + MessageBoxButtons.OK  + MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Bienvenido!");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMiForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludarOtroForm_Click(object sender, EventArgs e)
        {
            FrmSaludar frmSaludar = new FrmSaludar(); //por ahora lo carga en memoria/instancia pero no lo muestra
            frmSaludar.Show();
        }
    }
                      
}