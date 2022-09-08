namespace Clase05_Ej02
{
    partial class FrmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBoxDetallesDelUusario = new System.Windows.Forms.GroupBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioButtonNoBinario = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.groupBoxCursos = new System.Windows.Forms.GroupBox();
            this.checkBoxJS = new System.Windows.Forms.CheckBox();
            this.checkBoxCPLUSPLUS = new System.Windows.Forms.CheckBox();
            this.checkBoxCESHARP = new System.Windows.Forms.CheckBox();
            this.listBoxPaises = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.groupBoxDetallesDelUusario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.groupBoxGenero.SuspendLayout();
            this.groupBoxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(285, 299);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(96, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBoxDetallesDelUusario
            // 
            this.groupBoxDetallesDelUusario.Controls.Add(this.textBoxDireccion);
            this.groupBoxDetallesDelUusario.Controls.Add(this.textBoxNombre);
            this.groupBoxDetallesDelUusario.Controls.Add(this.numericUpDownEdad);
            this.groupBoxDetallesDelUusario.Controls.Add(this.lblEdad);
            this.groupBoxDetallesDelUusario.Controls.Add(this.lblDireccion);
            this.groupBoxDetallesDelUusario.Controls.Add(this.lblName);
            this.groupBoxDetallesDelUusario.Location = new System.Drawing.Point(12, 21);
            this.groupBoxDetallesDelUusario.Name = "groupBoxDetallesDelUusario";
            this.groupBoxDetallesDelUusario.Size = new System.Drawing.Size(200, 126);
            this.groupBoxDetallesDelUusario.TabIndex = 1;
            this.groupBoxDetallesDelUusario.TabStop = false;
            this.groupBoxDetallesDelUusario.Text = "Detalles del usuario";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(72, 56);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(114, 23);
            this.textBoxDireccion.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(72, 28);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(114, 23);
            this.textBoxNombre.TabIndex = 7;
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(72, 88);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(85, 23);
            this.numericUpDownEdad.TabIndex = 6;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(9, 88);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 57);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioButtonNoBinario);
            this.groupBoxGenero.Controls.Add(this.radioButtonFemenino);
            this.groupBoxGenero.Controls.Add(this.radioButtonMasculino);
            this.groupBoxGenero.Location = new System.Drawing.Point(258, 32);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(126, 100);
            this.groupBoxGenero.TabIndex = 2;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Género";
            // 
            // radioButtonNoBinario
            // 
            this.radioButtonNoBinario.AutoSize = true;
            this.radioButtonNoBinario.Location = new System.Drawing.Point(18, 71);
            this.radioButtonNoBinario.Name = "radioButtonNoBinario";
            this.radioButtonNoBinario.Size = new System.Drawing.Size(81, 19);
            this.radioButtonNoBinario.TabIndex = 2;
            this.radioButtonNoBinario.TabStop = true;
            this.radioButtonNoBinario.Text = "No Binario";
            this.radioButtonNoBinario.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(18, 46);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(78, 19);
            this.radioButtonFemenino.TabIndex = 1;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(18, 22);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBoxCursos
            // 
            this.groupBoxCursos.Controls.Add(this.checkBoxJS);
            this.groupBoxCursos.Controls.Add(this.checkBoxCPLUSPLUS);
            this.groupBoxCursos.Controls.Add(this.checkBoxCESHARP);
            this.groupBoxCursos.Location = new System.Drawing.Point(258, 170);
            this.groupBoxCursos.Name = "groupBoxCursos";
            this.groupBoxCursos.Size = new System.Drawing.Size(123, 100);
            this.groupBoxCursos.TabIndex = 2;
            this.groupBoxCursos.TabStop = false;
            this.groupBoxCursos.Text = "Cursos";
            // 
            // checkBoxJS
            // 
            this.checkBoxJS.AutoSize = true;
            this.checkBoxJS.Location = new System.Drawing.Point(15, 72);
            this.checkBoxJS.Name = "checkBoxJS";
            this.checkBoxJS.Size = new System.Drawing.Size(77, 19);
            this.checkBoxJS.TabIndex = 2;
            this.checkBoxJS.Text = "Javascript";
            this.checkBoxJS.UseVisualStyleBackColor = true;
            // 
            // checkBoxCPLUSPLUS
            // 
            this.checkBoxCPLUSPLUS.AutoSize = true;
            this.checkBoxCPLUSPLUS.Location = new System.Drawing.Point(15, 47);
            this.checkBoxCPLUSPLUS.Name = "checkBoxCPLUSPLUS";
            this.checkBoxCPLUSPLUS.Size = new System.Drawing.Size(50, 19);
            this.checkBoxCPLUSPLUS.TabIndex = 1;
            this.checkBoxCPLUSPLUS.Text = "C++";
            this.checkBoxCPLUSPLUS.UseVisualStyleBackColor = true;
            // 
            // checkBoxCESHARP
            // 
            this.checkBoxCESHARP.AutoSize = true;
            this.checkBoxCESHARP.Location = new System.Drawing.Point(15, 22);
            this.checkBoxCESHARP.Name = "checkBoxCESHARP";
            this.checkBoxCESHARP.Size = new System.Drawing.Size(41, 19);
            this.checkBoxCESHARP.TabIndex = 0;
            this.checkBoxCESHARP.Text = "C#";
            this.checkBoxCESHARP.UseVisualStyleBackColor = true;
            // 
            // listBoxPaises
            // 
            this.listBoxPaises.FormattingEnabled = true;
            this.listBoxPaises.ItemHeight = 15;
            this.listBoxPaises.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listBoxPaises.Location = new System.Drawing.Point(12, 192);
            this.listBoxPaises.Name = "listBoxPaises";
            this.listBoxPaises.Size = new System.Drawing.Size(176, 94);
            this.listBoxPaises.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(13, 170);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 329);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.listBoxPaises);
            this.Controls.Add(this.groupBoxCursos);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.groupBoxDetallesDelUusario);
            this.Controls.Add(this.btnIngresar);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
           
            this.groupBoxDetallesDelUusario.ResumeLayout(false);
            this.groupBoxDetallesDelUusario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.groupBoxCursos.ResumeLayout(false);
            this.groupBoxCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIngresar;
        private GroupBox groupBoxDetallesDelUusario;
        private TextBox textBoxDireccion;
        private TextBox textBoxNombre;
        private NumericUpDown numericUpDownEdad;
        private Label lblEdad;
        private Label lblDireccion;
        private Label lblName;
        private GroupBox groupBoxGenero;
        private RadioButton radioButtonNoBinario;
        private RadioButton radioButtonFemenino;
        private RadioButton radioButtonMasculino;
        private GroupBox groupBoxCursos;
        private CheckBox checkBoxJS;
        private CheckBox checkBoxCPLUSPLUS;
        private CheckBox checkBoxCESHARP;
        private ListBox listBoxPaises;
        private Label lblPais;
    }
}