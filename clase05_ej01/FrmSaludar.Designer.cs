namespace clase05_ej01
{
    partial class FrmSaludar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.ForeColor = System.Drawing.Color.Coral;
            this.lblSaludo.Location = new System.Drawing.Point(278, 64);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(121, 36);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "label1";
            this.lblSaludo.Click += new System.EventHandler(this.lblSaludo_Click);
            // 
            // FrmSaludar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaludo);
            this.Name = "FrmSaludar";
            this.Text = "FrmSaludar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSaludo;
    }
}