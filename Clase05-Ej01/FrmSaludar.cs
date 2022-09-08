using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05_Ej01
{
    public partial class FrmSaludar : Form
    {
        //podriamos sobrecargar el metodo para recibir mensaje pero corresponde para este form que siempre reciba un titulo y mensaje
        public FrmSaludar(string titulo, string mensaje)
        {
            InitializeComponent();
            this.lblTitulo.Text = titulo;
            this.lblMensaje.Text = mensaje;
        }





        //crearemos un metodo que reciba string y muestre en un label; 
        //nos comunicamos con el FrmPrincipal

        //metodo que enviaba mensaje al formSaludar, funciona bien, pero la consigna pedia que lo hicera el constructor de la clase
        //public void saludarConNombreCompleto(string nombreCompleto)
        //{ 
        //    //this.lblNombreCompleto.Text = "Soy " + nombreCompleto + "."; //cambie los nombres
        //    this.lblNombreCompleto.Text =$"Soy {nombreCompleto}.";
        //}
       
    }
}
