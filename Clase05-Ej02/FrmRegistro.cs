using Clase05_formClases;
using System.Windows.Forms;

namespace Clase05_Ej02
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string? nombre, direccion, pais, generoSeleccionado;
            string[] cursosSeleccionados;
            int edad;
            bool flagCursos = false;
            
            //Leemos datos desde el FrrmRegistro.
            nombre = this.textBoxNombre.Text;
            direccion = this.textBoxDireccion.Text;
            pais = this.listBoxPaises.Text;
            edad = (int)this.numericUpDownEdad.Value;

            generoSeleccionado = string.Empty;
            foreach (RadioButton radioB in this.groupBoxGenero.Controls.OfType<RadioButton>())
            {
                if (radioB.Checked)
                {
                    generoSeleccionado = radioB.Text;
                }
            }

             cursosSeleccionados = new string[this.groupBoxCursos.Controls.Count];
            int indexCheckBox = 0;
            foreach (CheckBox chkBox in this.groupBoxCursos.Controls.OfType<CheckBox>())
            {
                if (chkBox.Checked)
                {
                    flagCursos = true;
                    cursosSeleccionados[indexCheckBox] = chkBox.Text;
                    indexCheckBox++;
                }

            }

            if (!flagCursos || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(pais) || string.IsNullOrEmpty(generoSeleccionado) || edad < 17)
            {
                MessageBox.Show("Error! debe llenar todos los campos y ser mayo a 16 años.");
            }
            else
            {
                 Ingresante nuevoIngresante = new Ingresante(nombre, direccion,generoSeleccionado, pais, cursosSeleccionados, edad);
                MessageBox.Show(nuevoIngresante.Mostrar());
            }




            // groupBoxDetallesDelUusario.Enabled = false; activa, desactiva el groupbox para el usuario

        }



    }





}