namespace Clase05_Ej05ConversorBinario
{
    partial class FrmConversorBinario
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
            this.lblBinarioADecimal = new System.Windows.Forms.Label();
            this.lblDecimalABinario = new System.Windows.Forms.Label();
            this.btnBinarioADecimal = new System.Windows.Forms.Button();
            this.btnDecimalABinario = new System.Windows.Forms.Button();
            this.txtBoxBinADecimalResultado = new System.Windows.Forms.TextBox();
            this.txtBoxDecABinResultado = new System.Windows.Forms.TextBox();
            this.txtBoxNumBinario = new System.Windows.Forms.TextBox();
            this.txtBoxNumDecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinarioADecimal
            // 
            this.lblBinarioADecimal.AutoSize = true;
            this.lblBinarioADecimal.Location = new System.Drawing.Point(30, 36);
            this.lblBinarioADecimal.Name = "lblBinarioADecimal";
            this.lblBinarioADecimal.Size = new System.Drawing.Size(99, 15);
            this.lblBinarioADecimal.TabIndex = 0;
            this.lblBinarioADecimal.Text = "Binario a Decimal";
            // 
            // lblDecimalABinario
            // 
            this.lblDecimalABinario.AutoSize = true;
            this.lblDecimalABinario.Location = new System.Drawing.Point(30, 77);
            this.lblDecimalABinario.Name = "lblDecimalABinario";
            this.lblDecimalABinario.Size = new System.Drawing.Size(99, 15);
            this.lblDecimalABinario.TabIndex = 1;
            this.lblDecimalABinario.Text = "Decimal a Binario";
            // 
            // btnBinarioADecimal
            // 
            this.btnBinarioADecimal.Location = new System.Drawing.Point(262, 33);
            this.btnBinarioADecimal.Name = "btnBinarioADecimal";
            this.btnBinarioADecimal.Size = new System.Drawing.Size(75, 23);
            this.btnBinarioADecimal.TabIndex = 2;
            this.btnBinarioADecimal.Text = "->";
            this.btnBinarioADecimal.UseVisualStyleBackColor = true;
            this.btnBinarioADecimal.Click += new System.EventHandler(this.btnBinarioADecimal_Click);
            // 
            // btnDecimalABinario
            // 
            this.btnDecimalABinario.Location = new System.Drawing.Point(262, 69);
            this.btnDecimalABinario.Name = "btnDecimalABinario";
            this.btnDecimalABinario.Size = new System.Drawing.Size(75, 23);
            this.btnDecimalABinario.TabIndex = 3;
            this.btnDecimalABinario.Text = "->";
            this.btnDecimalABinario.UseVisualStyleBackColor = true;
            this.btnDecimalABinario.Click += new System.EventHandler(this.btnDecimalABinario_Click);
            // 
            // txtBoxBinADecimalResultado
            // 
            this.txtBoxBinADecimalResultado.Location = new System.Drawing.Point(359, 33);
            this.txtBoxBinADecimalResultado.Name = "txtBoxBinADecimalResultado";
            this.txtBoxBinADecimalResultado.ReadOnly = true;
            this.txtBoxBinADecimalResultado.Size = new System.Drawing.Size(100, 23);
            this.txtBoxBinADecimalResultado.TabIndex = 4;
            // 
            // txtBoxDecABinResultado
            // 
            this.txtBoxDecABinResultado.Location = new System.Drawing.Point(359, 70);
            this.txtBoxDecABinResultado.Name = "txtBoxDecABinResultado";
            this.txtBoxDecABinResultado.ReadOnly = true;
            this.txtBoxDecABinResultado.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDecABinResultado.TabIndex = 5;
            // 
            // txtBoxNumBinario
            // 
            this.txtBoxNumBinario.Location = new System.Drawing.Point(147, 33);
            this.txtBoxNumBinario.Name = "txtBoxNumBinario";
            this.txtBoxNumBinario.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNumBinario.TabIndex = 6;
            // 
            // txtBoxNumDecimal
            // 
            this.txtBoxNumDecimal.Location = new System.Drawing.Point(147, 70);
            this.txtBoxNumDecimal.Name = "txtBoxNumDecimal";
            this.txtBoxNumDecimal.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNumDecimal.TabIndex = 7;
            // 
            // FrmConversorBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 112);
            this.Controls.Add(this.txtBoxNumDecimal);
            this.Controls.Add(this.txtBoxNumBinario);
            this.Controls.Add(this.txtBoxDecABinResultado);
            this.Controls.Add(this.txtBoxBinADecimalResultado);
            this.Controls.Add(this.btnDecimalABinario);
            this.Controls.Add(this.btnBinarioADecimal);
            this.Controls.Add(this.lblDecimalABinario);
            this.Controls.Add(this.lblBinarioADecimal);
            this.Name = "FrmConversorBinario";
            this.Text = "Conversor Binario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBinarioADecimal;
        private Label lblDecimalABinario;
        private Button btnBinarioADecimal;
        private Button btnDecimalABinario;
        private TextBox txtBoxBinADecimalResultado;
        private TextBox txtBoxDecABinResultado;
        private TextBox txtBoxNumBinario;
        private TextBox txtBoxNumDecimal;
    }
}