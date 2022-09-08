namespace clase05_ej01
{
    partial class FrmMiForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaludarOtroForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Saludar(button1)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Escriba el nombre";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSaludarOtroForm
            // 
            this.btnSaludarOtroForm.Location = new System.Drawing.Point(558, 203);
            this.btnSaludarOtroForm.Name = "btnSaludarOtroForm";
            this.btnSaludarOtroForm.Size = new System.Drawing.Size(75, 23);
            this.btnSaludarOtroForm.TabIndex = 3;
            this.btnSaludarOtroForm.Text = "btnSaludarDesdeOtro";
            this.btnSaludarOtroForm.UseVisualStyleBackColor = true;
            this.btnSaludarOtroForm.Click += new System.EventHandler(this.btnSaludarOtroForm_Click);
            // 
            // FrmMiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.btnSaludarOtroForm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmMiForm";
            this.Text = "MiPrimerFormulario";
            this.Load += new System.EventHandler(this.FrmMiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1; //se creo con las herramientas de diseño
        private Label label1;
        private TextBox textBox1;
        private Button btnSaludarOtroForm;
    }
}