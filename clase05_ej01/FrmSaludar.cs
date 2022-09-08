using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase05_ej01
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        public FrmSaludar(string nombre) : this()  //no nos olvidemos de que llame al constructor primero qu elo inicializa
        {
            this.lblSaludo.Text = nombre;
        }

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }
    }
}
