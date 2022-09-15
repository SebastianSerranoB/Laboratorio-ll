namespace Clase06_Ej03
{
    partial class FrmContador
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.richTxtBoxDiccionario = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(311, 355);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // richTxtBoxDiccionario
            // 
            this.richTxtBoxDiccionario.Location = new System.Drawing.Point(12, 12);
            this.richTxtBoxDiccionario.Name = "richTxtBoxDiccionario";
            this.richTxtBoxDiccionario.Size = new System.Drawing.Size(374, 337);
            this.richTxtBoxDiccionario.TabIndex = 1;
            this.richTxtBoxDiccionario.Text = "";
            // 
            // FrmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 390);
            this.Controls.Add(this.richTxtBoxDiccionario);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FrmContador";
            this.Text = "ContadorDePalabras";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCalcular;
        private RichTextBox richTxtBoxDiccionario;
    }
}