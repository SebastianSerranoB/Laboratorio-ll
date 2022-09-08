namespace Clase05_Ej01
{
    partial class FrmPrincipal
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblMateriaFavorita = new System.Windows.Forms.Label();
            this.comboBoxMaterias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(21, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(200, 19);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 15);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(200, 48);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(239, 163);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(144, 24);
            this.btnSaludar.TabIndex = 4;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lblMateriaFavorita
            // 
            this.lblMateriaFavorita.AutoSize = true;
            this.lblMateriaFavorita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMateriaFavorita.Location = new System.Drawing.Point(21, 91);
            this.lblMateriaFavorita.Name = "lblMateriaFavorita";
            this.lblMateriaFavorita.Size = new System.Drawing.Size(97, 15);
            this.lblMateriaFavorita.TabIndex = 5;
            this.lblMateriaFavorita.Text = "Materia favorita";
            // 
            // comboBoxMaterias
            // 
            this.comboBoxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterias.FormattingEnabled = true;
            this.comboBoxMaterias.Items.AddRange(new object[] {
            "Programacion l",
            "Laboratorio de Programacion l",
            "Matematica l",
            "Ingles l",
            "Sistemas de procesamiento de datos ",
            "Programacion ll",
            "Laboratorio de Programacion ll",
            "Arq. de Sistemas Operativos",
            "Ingles ll",
            "Estadistica",
            "Metodologia de la investigacion"});
            this.comboBoxMaterias.Location = new System.Drawing.Point(12, 109);
            this.comboBoxMaterias.Name = "comboBoxMaterias";
            this.comboBoxMaterias.Size = new System.Drawing.Size(371, 23);
            this.comboBoxMaterias.TabIndex = 6;
            this.comboBoxMaterias.Tag = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 199);
            this.Controls.Add(this.comboBoxMaterias);
            this.Controls.Add(this.lblMateriaFavorita);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnSaludar;
        private Label lblMateriaFavorita;
        private ComboBox comboBoxMaterias;
    }
}