namespace Clase05_Ej03
{
    partial class FrmMonedas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonedas));
            this.txtBoxCotizPeso = new System.Windows.Forms.TextBox();
            this.txtBoxCantidadEuro = new System.Windows.Forms.TextBox();
            this.txtBoxCotizEuro = new System.Windows.Forms.TextBox();
            this.txtBoxCotizDolar = new System.Windows.Forms.TextBox();
            this.txtBoxCantidadPeso = new System.Windows.Forms.TextBox();
            this.txtBoxCantidadDolar = new System.Windows.Forms.TextBox();
            this.btnConversorEuro = new System.Windows.Forms.Button();
            this.btnConversorDolar = new System.Windows.Forms.Button();
            this.btnConversorPeso = new System.Windows.Forms.Button();
            this.btnCandado = new System.Windows.Forms.Button();
            this.imageListBtnLock = new System.Windows.Forms.ImageList(this.components);
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblDolar2 = new System.Windows.Forms.Label();
            this.lblPeso2 = new System.Windows.Forms.Label();
            this.txtBoxEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtBoxEuroADolar = new System.Windows.Forms.TextBox();
            this.txtBoxEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtBoxDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtBoxDolarADolar = new System.Windows.Forms.TextBox();
            this.txtBoxDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtBoxPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtBoxPesoADolar = new System.Windows.Forms.TextBox();
            this.txtBoxPesoAPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxCotizPeso
            // 
            this.txtBoxCotizPeso.Location = new System.Drawing.Point(480, 12);
            this.txtBoxCotizPeso.Name = "txtBoxCotizPeso";
            this.txtBoxCotizPeso.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCotizPeso.TabIndex = 0;
            this.txtBoxCotizPeso.Leave += new System.EventHandler(this.txtBoxCotizPeso_Leave);
            // 
            // txtBoxCantidadEuro
            // 
            this.txtBoxCantidadEuro.Location = new System.Drawing.Point(69, 61);
            this.txtBoxCantidadEuro.Name = "txtBoxCantidadEuro";
            this.txtBoxCantidadEuro.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCantidadEuro.TabIndex = 1;
            // 
            // txtBoxCotizEuro
            // 
            this.txtBoxCotizEuro.Location = new System.Drawing.Point(268, 12);
            this.txtBoxCotizEuro.Name = "txtBoxCotizEuro";
            this.txtBoxCotizEuro.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCotizEuro.TabIndex = 2;
            this.txtBoxCotizEuro.Leave += new System.EventHandler(this.txtBoxCotizEuro_Leave);
            // 
            // txtBoxCotizDolar
            // 
            this.txtBoxCotizDolar.Location = new System.Drawing.Point(374, 12);
            this.txtBoxCotizDolar.Name = "txtBoxCotizDolar";
            this.txtBoxCotizDolar.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCotizDolar.TabIndex = 3;
            this.txtBoxCotizDolar.Leave += new System.EventHandler(this.txtBoxCotizDolar_Leave);
            // 
            // txtBoxCantidadPeso
            // 
            this.txtBoxCantidadPeso.Location = new System.Drawing.Point(69, 119);
            this.txtBoxCantidadPeso.Name = "txtBoxCantidadPeso";
            this.txtBoxCantidadPeso.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCantidadPeso.TabIndex = 4;
            // 
            // txtBoxCantidadDolar
            // 
            this.txtBoxCantidadDolar.Location = new System.Drawing.Point(69, 91);
            this.txtBoxCantidadDolar.Name = "txtBoxCantidadDolar";
            this.txtBoxCantidadDolar.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCantidadDolar.TabIndex = 5;
            // 
            // btnConversorEuro
            // 
            this.btnConversorEuro.Location = new System.Drawing.Point(175, 61);
            this.btnConversorEuro.Name = "btnConversorEuro";
            this.btnConversorEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConversorEuro.TabIndex = 6;
            this.btnConversorEuro.Text = "->";
            this.btnConversorEuro.UseVisualStyleBackColor = true;
            this.btnConversorEuro.Click += new System.EventHandler(this.btnConversorEuro_Click);
            // 
            // btnConversorDolar
            // 
            this.btnConversorDolar.Location = new System.Drawing.Point(175, 90);
            this.btnConversorDolar.Name = "btnConversorDolar";
            this.btnConversorDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConversorDolar.TabIndex = 7;
            this.btnConversorDolar.Text = "->";
            this.btnConversorDolar.UseVisualStyleBackColor = true;
            this.btnConversorDolar.Click += new System.EventHandler(this.btnConversorDolar_Click);
            // 
            // btnConversorPeso
            // 
            this.btnConversorPeso.Location = new System.Drawing.Point(175, 119);
            this.btnConversorPeso.Name = "btnConversorPeso";
            this.btnConversorPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConversorPeso.TabIndex = 8;
            this.btnConversorPeso.Text = "->";
            this.btnConversorPeso.UseVisualStyleBackColor = true;
            this.btnConversorPeso.Click += new System.EventHandler(this.btnConversorPeso_Click);
            // 
            // btnCandado
            // 
            this.btnCandado.ImageIndex = 0;
            this.btnCandado.ImageList = this.imageListBtnLock;
            this.btnCandado.Location = new System.Drawing.Point(175, 10);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(75, 25);
            this.btnCandado.TabIndex = 9;
            this.btnCandado.UseVisualStyleBackColor = true;
            this.btnCandado.Click += new System.EventHandler(this.btnCandado_Click);
            // 
            // imageListBtnLock
            // 
            this.imageListBtnLock.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListBtnLock.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBtnLock.ImageStream")));
            this.imageListBtnLock.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBtnLock.Images.SetKeyName(0, "unlocked_1f513.png");
            this.imageListBtnLock.Images.SetKeyName(1, "locked_1f512.png");
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCotizacion.Location = new System.Drawing.Point(83, 12);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(76, 19);
            this.lblCotizacion.TabIndex = 10;
            this.lblCotizacion.Text = "Cotización";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEuro.Location = new System.Drawing.Point(14, 61);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(38, 19);
            this.lblEuro.TabIndex = 11;
            this.lblEuro.Text = "Euro";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPeso.Location = new System.Drawing.Point(13, 120);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 19);
            this.lblPeso.TabIndex = 12;
            this.lblPeso.Text = "Peso";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDolar.Location = new System.Drawing.Point(12, 90);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(46, 19);
            this.lblDolar.TabIndex = 13;
            this.lblDolar.Text = "Dólar";
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEuro2.Location = new System.Drawing.Point(296, 40);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(38, 19);
            this.lblEuro2.TabIndex = 14;
            this.lblEuro2.Text = "Euro";
            // 
            // lblDolar2
            // 
            this.lblDolar2.AutoSize = true;
            this.lblDolar2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDolar2.Location = new System.Drawing.Point(404, 40);
            this.lblDolar2.Name = "lblDolar2";
            this.lblDolar2.Size = new System.Drawing.Size(46, 19);
            this.lblDolar2.TabIndex = 15;
            this.lblDolar2.Text = "Dólar";
            // 
            // lblPeso2
            // 
            this.lblPeso2.AutoSize = true;
            this.lblPeso2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPeso2.Location = new System.Drawing.Point(514, 40);
            this.lblPeso2.Name = "lblPeso2";
            this.lblPeso2.Size = new System.Drawing.Size(39, 19);
            this.lblPeso2.TabIndex = 16;
            this.lblPeso2.Text = "Peso";
            // 
            // txtBoxEuroAEuro
            // 
            this.txtBoxEuroAEuro.Location = new System.Drawing.Point(268, 62);
            this.txtBoxEuroAEuro.Name = "txtBoxEuroAEuro";
            this.txtBoxEuroAEuro.ReadOnly = true;
            this.txtBoxEuroAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtBoxEuroAEuro.TabIndex = 17;
            // 
            // txtBoxEuroADolar
            // 
            this.txtBoxEuroADolar.Location = new System.Drawing.Point(376, 62);
            this.txtBoxEuroADolar.Name = "txtBoxEuroADolar";
            this.txtBoxEuroADolar.ReadOnly = true;
            this.txtBoxEuroADolar.Size = new System.Drawing.Size(100, 23);
            this.txtBoxEuroADolar.TabIndex = 18;
            // 
            // txtBoxEuroAPeso
            // 
            this.txtBoxEuroAPeso.Location = new System.Drawing.Point(482, 62);
            this.txtBoxEuroAPeso.Name = "txtBoxEuroAPeso";
            this.txtBoxEuroAPeso.ReadOnly = true;
            this.txtBoxEuroAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtBoxEuroAPeso.TabIndex = 19;
            // 
            // txtBoxDolarAEuro
            // 
            this.txtBoxDolarAEuro.Location = new System.Drawing.Point(268, 90);
            this.txtBoxDolarAEuro.Name = "txtBoxDolarAEuro";
            this.txtBoxDolarAEuro.ReadOnly = true;
            this.txtBoxDolarAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDolarAEuro.TabIndex = 20;
            // 
            // txtBoxDolarADolar
            // 
            this.txtBoxDolarADolar.Location = new System.Drawing.Point(376, 90);
            this.txtBoxDolarADolar.Name = "txtBoxDolarADolar";
            this.txtBoxDolarADolar.ReadOnly = true;
            this.txtBoxDolarADolar.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDolarADolar.TabIndex = 21;
            // 
            // txtBoxDolarAPeso
            // 
            this.txtBoxDolarAPeso.Location = new System.Drawing.Point(482, 90);
            this.txtBoxDolarAPeso.Name = "txtBoxDolarAPeso";
            this.txtBoxDolarAPeso.ReadOnly = true;
            this.txtBoxDolarAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDolarAPeso.TabIndex = 22;
            // 
            // txtBoxPesoAEuro
            // 
            this.txtBoxPesoAEuro.Location = new System.Drawing.Point(268, 119);
            this.txtBoxPesoAEuro.Name = "txtBoxPesoAEuro";
            this.txtBoxPesoAEuro.ReadOnly = true;
            this.txtBoxPesoAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPesoAEuro.TabIndex = 23;
            // 
            // txtBoxPesoADolar
            // 
            this.txtBoxPesoADolar.Location = new System.Drawing.Point(376, 119);
            this.txtBoxPesoADolar.Name = "txtBoxPesoADolar";
            this.txtBoxPesoADolar.ReadOnly = true;
            this.txtBoxPesoADolar.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPesoADolar.TabIndex = 24;
            // 
            // txtBoxPesoAPeso
            // 
            this.txtBoxPesoAPeso.Location = new System.Drawing.Point(482, 119);
            this.txtBoxPesoAPeso.Name = "txtBoxPesoAPeso";
            this.txtBoxPesoAPeso.ReadOnly = true;
            this.txtBoxPesoAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPesoAPeso.TabIndex = 25;
            // 
            // FrmMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 158);
            this.Controls.Add(this.txtBoxPesoAPeso);
            this.Controls.Add(this.txtBoxPesoADolar);
            this.Controls.Add(this.txtBoxPesoAEuro);
            this.Controls.Add(this.txtBoxDolarAPeso);
            this.Controls.Add(this.txtBoxDolarADolar);
            this.Controls.Add(this.txtBoxDolarAEuro);
            this.Controls.Add(this.txtBoxEuroAPeso);
            this.Controls.Add(this.txtBoxEuroADolar);
            this.Controls.Add(this.txtBoxEuroAEuro);
            this.Controls.Add(this.lblPeso2);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.btnCandado);
            this.Controls.Add(this.btnConversorPeso);
            this.Controls.Add(this.btnConversorDolar);
            this.Controls.Add(this.btnConversorEuro);
            this.Controls.Add(this.txtBoxCantidadDolar);
            this.Controls.Add(this.txtBoxCantidadPeso);
            this.Controls.Add(this.txtBoxCotizDolar);
            this.Controls.Add(this.txtBoxCotizEuro);
            this.Controls.Add(this.txtBoxCantidadEuro);
            this.Controls.Add(this.txtBoxCotizPeso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxCotizPeso;
        private TextBox txtBoxCantidadEuro;
        private TextBox txtBoxCotizEuro;
        private TextBox txtBoxCotizDolar;
        private TextBox txtBoxCantidadPeso;
        private TextBox txtBoxCantidadDolar;
        private Button btnConversorEuro;
        private Button btnConversorDolar;
        private Button btnConversorPeso;
        private Button btnCandado;
        private ImageList imageListBtnLock;
        private Label lblCotizacion;
        private Label lblEuro;
        private Label lblPeso;
        private Label lblDolar;
        private Label lblEuro2;
        private Label lblDolar2;
        private Label lblPeso2;
        private TextBox txtBoxEuroAEuro;
        private TextBox txtBoxEuroADolar;
        private TextBox txtBoxEuroAPeso;
        private TextBox txtBoxDolarAEuro;
        private TextBox txtBoxDolarADolar;
        private TextBox txtBoxDolarAPeso;
        private TextBox txtBoxPesoAEuro;
        private TextBox txtBoxPesoADolar;
        private TextBox txtBoxPesoAPeso;
    }
}