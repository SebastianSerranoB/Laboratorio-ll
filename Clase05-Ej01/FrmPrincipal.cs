namespace Clase05_Ej01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            FrmSaludar menuSaludar;
            string titulo, mensaje, nombre, apellido;

            titulo = "¡Hola, Windows Forms!";
            nombre = this.txtNombre.Text;
            apellido = this.txtApellido.Text;



            //corresponde una funcion de validacion
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido))
            {
                //el metodo show de la calse messagebox tiene muchas sobrecargas, para el titulo, mensaje, iconos, botonoes, etc
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre\nApellido",
                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Se deben completar los siguientes campos:\nNombre",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrEmpty(apellido))
                    {
                        MessageBox.Show("Se deben completar los siguientes campos:\nApellido",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        mensaje = $"Soy {nombre} {apellido} y mi materia favorita es {this.comboBoxMaterias.Text}.";
                        menuSaludar = new FrmSaludar(titulo, mensaje);
                        menuSaludar.ShowDialog();
   
                    }
                }
            }





            //Interacccion entre formularios, tomamos un nombre desde el form principal y a traves de este metodo del form saludar le enviamos el nombre recibido y lo mostrara el
            // menuSaludar.saludarConNombreCompleto(nombreCompleto); //saludar con METODO
            //forma modal (no podemos interactuar con otro formulario mientras estemos con este)
            //recordemos que el formulario es una clase, el textbox es tambien una clase con sus caracteristicas particulares
            //this(formulario).textboxNombre.propiedadText ( lee el contenido de ese componente)
            //nosotros buscamos que el nombre y apellido ingresados en el FrmPrincipal se muestren en otro formulario, el de saludar
            //entonces, dentro de el evento click del boton saludar(frmPrincipal), creamos un objeto del tipo FrmSaludar y lo instanciamos
            //aqui se creo en memoria, pero no se muestra en pantalla
            //esta es la manera MODAL de mostrarlo, ahora si lo abre y muestra cuando ejecutamos y presionamos saludar en frmPrincipal
            //con la manera MODAl, no nos permite interactuar con otro formulario que no sea este (menuSaludar).
            // this.Hide();  esto sirve para ocultar el formulario principal. 
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.comboBoxMaterias.SelectedIndex = 0;
        }
    }
}