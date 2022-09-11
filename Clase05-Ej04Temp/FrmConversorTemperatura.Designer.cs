namespace Clase05_Ej04Temp
{
    partial class FrmConversorTemperatura
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
            this.lblFahrenheitGrados = new System.Windows.Forms.Label();
            this.lblCelsiusGrados = new System.Windows.Forms.Label();
            this.lblKelvinGrados = new System.Windows.Forms.Label();
            this.lblFahrenheitResultado = new System.Windows.Forms.Label();
            this.lblCelsiusResultado = new System.Windows.Forms.Label();
            this.lblKelvinResultado = new System.Windows.Forms.Label();
            this.btnConversorFahrenheit = new System.Windows.Forms.Button();
            this.btnConversorCelsius = new System.Windows.Forms.Button();
            this.btnConversorKelvin = new System.Windows.Forms.Button();
            this.txtBoxFahrenheitGrados = new System.Windows.Forms.TextBox();
            this.txtBoxCelsiusGrados = new System.Windows.Forms.TextBox();
            this.txtBoxKelvinGrados = new System.Windows.Forms.TextBox();
            this.txtBoxFahrenheitAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtBoxFahrenheitACelsius = new System.Windows.Forms.TextBox();
            this.txtBoxFahrenheitAKelvin = new System.Windows.Forms.TextBox();
            this.txtBoxCelsiusAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtBoxCelsiusACelsius = new System.Windows.Forms.TextBox();
            this.txtBoxCelsiusAKelvin = new System.Windows.Forms.TextBox();
            this.txtBoxKelvinAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtBoxKelvinACelsius = new System.Windows.Forms.TextBox();
            this.txtBoxKelvinAKelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFahrenheitGrados
            // 
            this.lblFahrenheitGrados.AutoSize = true;
            this.lblFahrenheitGrados.Location = new System.Drawing.Point(17, 32);
            this.lblFahrenheitGrados.Name = "lblFahrenheitGrados";
            this.lblFahrenheitGrados.Size = new System.Drawing.Size(63, 15);
            this.lblFahrenheitGrados.TabIndex = 0;
            this.lblFahrenheitGrados.Text = "Fahrenheit";
            // 
            // lblCelsiusGrados
            // 
            this.lblCelsiusGrados.AutoSize = true;
            this.lblCelsiusGrados.Location = new System.Drawing.Point(17, 63);
            this.lblCelsiusGrados.Name = "lblCelsiusGrados";
            this.lblCelsiusGrados.Size = new System.Drawing.Size(44, 15);
            this.lblCelsiusGrados.TabIndex = 1;
            this.lblCelsiusGrados.Text = "Celsius";
            // 
            // lblKelvinGrados
            // 
            this.lblKelvinGrados.AutoSize = true;
            this.lblKelvinGrados.Location = new System.Drawing.Point(17, 94);
            this.lblKelvinGrados.Name = "lblKelvinGrados";
            this.lblKelvinGrados.Size = new System.Drawing.Size(39, 15);
            this.lblKelvinGrados.TabIndex = 2;
            this.lblKelvinGrados.Text = "Kelvin";
            // 
            // lblFahrenheitResultado
            // 
            this.lblFahrenheitResultado.AutoSize = true;
            this.lblFahrenheitResultado.Location = new System.Drawing.Point(334, 9);
            this.lblFahrenheitResultado.Name = "lblFahrenheitResultado";
            this.lblFahrenheitResultado.Size = new System.Drawing.Size(63, 15);
            this.lblFahrenheitResultado.TabIndex = 3;
            this.lblFahrenheitResultado.Text = "Fahrenheit";
            // 
            // lblCelsiusResultado
            // 
            this.lblCelsiusResultado.AutoSize = true;
            this.lblCelsiusResultado.Location = new System.Drawing.Point(463, 9);
            this.lblCelsiusResultado.Name = "lblCelsiusResultado";
            this.lblCelsiusResultado.Size = new System.Drawing.Size(44, 15);
            this.lblCelsiusResultado.TabIndex = 4;
            this.lblCelsiusResultado.Text = "Celsius";
            // 
            // lblKelvinResultado
            // 
            this.lblKelvinResultado.AutoSize = true;
            this.lblKelvinResultado.Location = new System.Drawing.Point(583, 9);
            this.lblKelvinResultado.Name = "lblKelvinResultado";
            this.lblKelvinResultado.Size = new System.Drawing.Size(39, 15);
            this.lblKelvinResultado.TabIndex = 5;
            this.lblKelvinResultado.Text = "Kelvin";
            // 
            // btnConversorFahrenheit
            // 
            this.btnConversorFahrenheit.Location = new System.Drawing.Point(225, 32);
            this.btnConversorFahrenheit.Name = "btnConversorFahrenheit";
            this.btnConversorFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btnConversorFahrenheit.TabIndex = 6;
            this.btnConversorFahrenheit.Text = "->";
            this.btnConversorFahrenheit.UseVisualStyleBackColor = true;
            this.btnConversorFahrenheit.Click += new System.EventHandler(this.btnConversorFahrenheit_Click);
            // 
            // btnConversorCelsius
            // 
            this.btnConversorCelsius.Location = new System.Drawing.Point(225, 66);
            this.btnConversorCelsius.Name = "btnConversorCelsius";
            this.btnConversorCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnConversorCelsius.TabIndex = 7;
            this.btnConversorCelsius.Text = "->";
            this.btnConversorCelsius.UseVisualStyleBackColor = true;
            this.btnConversorCelsius.Click += new System.EventHandler(this.btnConversorCelsius_Click);
            // 
            // btnConversorKelvin
            // 
            this.btnConversorKelvin.Location = new System.Drawing.Point(225, 94);
            this.btnConversorKelvin.Name = "btnConversorKelvin";
            this.btnConversorKelvin.Size = new System.Drawing.Size(75, 23);
            this.btnConversorKelvin.TabIndex = 8;
            this.btnConversorKelvin.Text = "->";
            this.btnConversorKelvin.UseVisualStyleBackColor = true;
            this.btnConversorKelvin.Click += new System.EventHandler(this.btnConversorKelvin_Click);
            // 
            // txtBoxFahrenheitGrados
            // 
            this.txtBoxFahrenheitGrados.Location = new System.Drawing.Point(119, 32);
            this.txtBoxFahrenheitGrados.Name = "txtBoxFahrenheitGrados";
            this.txtBoxFahrenheitGrados.Size = new System.Drawing.Size(100, 23);
            this.txtBoxFahrenheitGrados.TabIndex = 9;
            // 
            // txtBoxCelsiusGrados
            // 
            this.txtBoxCelsiusGrados.Location = new System.Drawing.Point(119, 63);
            this.txtBoxCelsiusGrados.Name = "txtBoxCelsiusGrados";
            this.txtBoxCelsiusGrados.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCelsiusGrados.TabIndex = 10;
            // 
            // txtBoxKelvinGrados
            // 
            this.txtBoxKelvinGrados.Location = new System.Drawing.Point(119, 92);
            this.txtBoxKelvinGrados.Name = "txtBoxKelvinGrados";
            this.txtBoxKelvinGrados.Size = new System.Drawing.Size(100, 23);
            this.txtBoxKelvinGrados.TabIndex = 11;
            // 
            // txtBoxFahrenheitAFahrenheit
            // 
            this.txtBoxFahrenheitAFahrenheit.Location = new System.Drawing.Point(315, 32);
            this.txtBoxFahrenheitAFahrenheit.Name = "txtBoxFahrenheitAFahrenheit";
            this.txtBoxFahrenheitAFahrenheit.ReadOnly = true;
            this.txtBoxFahrenheitAFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txtBoxFahrenheitAFahrenheit.TabIndex = 12;
            // 
            // txtBoxFahrenheitACelsius
            // 
            this.txtBoxFahrenheitACelsius.Location = new System.Drawing.Point(435, 32);
            this.txtBoxFahrenheitACelsius.Name = "txtBoxFahrenheitACelsius";
            this.txtBoxFahrenheitACelsius.ReadOnly = true;
            this.txtBoxFahrenheitACelsius.Size = new System.Drawing.Size(100, 23);
            this.txtBoxFahrenheitACelsius.TabIndex = 13;
            // 
            // txtBoxFahrenheitAKelvin
            // 
            this.txtBoxFahrenheitAKelvin.Location = new System.Drawing.Point(548, 32);
            this.txtBoxFahrenheitAKelvin.Name = "txtBoxFahrenheitAKelvin";
            this.txtBoxFahrenheitAKelvin.ReadOnly = true;
            this.txtBoxFahrenheitAKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtBoxFahrenheitAKelvin.TabIndex = 14;
            // 
            // txtBoxCelsiusAFahrenheit
            // 
            this.txtBoxCelsiusAFahrenheit.Location = new System.Drawing.Point(315, 63);
            this.txtBoxCelsiusAFahrenheit.Name = "txtBoxCelsiusAFahrenheit";
            this.txtBoxCelsiusAFahrenheit.ReadOnly = true;
            this.txtBoxCelsiusAFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCelsiusAFahrenheit.TabIndex = 15;
            // 
            // txtBoxCelsiusACelsius
            // 
            this.txtBoxCelsiusACelsius.Location = new System.Drawing.Point(435, 63);
            this.txtBoxCelsiusACelsius.Name = "txtBoxCelsiusACelsius";
            this.txtBoxCelsiusACelsius.ReadOnly = true;
            this.txtBoxCelsiusACelsius.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCelsiusACelsius.TabIndex = 16;
            // 
            // txtBoxCelsiusAKelvin
            // 
            this.txtBoxCelsiusAKelvin.Location = new System.Drawing.Point(548, 61);
            this.txtBoxCelsiusAKelvin.Name = "txtBoxCelsiusAKelvin";
            this.txtBoxCelsiusAKelvin.ReadOnly = true;
            this.txtBoxCelsiusAKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCelsiusAKelvin.TabIndex = 17;
            // 
            // txtBoxKelvinAFahrenheit
            // 
            this.txtBoxKelvinAFahrenheit.Location = new System.Drawing.Point(315, 94);
            this.txtBoxKelvinAFahrenheit.Name = "txtBoxKelvinAFahrenheit";
            this.txtBoxKelvinAFahrenheit.ReadOnly = true;
            this.txtBoxKelvinAFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txtBoxKelvinAFahrenheit.TabIndex = 18;
            // 
            // txtBoxKelvinACelsius
            // 
            this.txtBoxKelvinACelsius.Location = new System.Drawing.Point(435, 94);
            this.txtBoxKelvinACelsius.Name = "txtBoxKelvinACelsius";
            this.txtBoxKelvinACelsius.ReadOnly = true;
            this.txtBoxKelvinACelsius.Size = new System.Drawing.Size(100, 23);
            this.txtBoxKelvinACelsius.TabIndex = 19;
            // 
            // txtBoxKelvinAKelvin
            // 
            this.txtBoxKelvinAKelvin.Location = new System.Drawing.Point(548, 94);
            this.txtBoxKelvinAKelvin.Name = "txtBoxKelvinAKelvin";
            this.txtBoxKelvinAKelvin.ReadOnly = true;
            this.txtBoxKelvinAKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtBoxKelvinAKelvin.TabIndex = 20;
            // 
            // FrmConversorTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 128);
            this.Controls.Add(this.txtBoxKelvinAKelvin);
            this.Controls.Add(this.txtBoxKelvinACelsius);
            this.Controls.Add(this.txtBoxKelvinAFahrenheit);
            this.Controls.Add(this.txtBoxCelsiusAKelvin);
            this.Controls.Add(this.txtBoxCelsiusACelsius);
            this.Controls.Add(this.txtBoxCelsiusAFahrenheit);
            this.Controls.Add(this.txtBoxFahrenheitAKelvin);
            this.Controls.Add(this.txtBoxFahrenheitACelsius);
            this.Controls.Add(this.txtBoxFahrenheitAFahrenheit);
            this.Controls.Add(this.txtBoxKelvinGrados);
            this.Controls.Add(this.txtBoxCelsiusGrados);
            this.Controls.Add(this.txtBoxFahrenheitGrados);
            this.Controls.Add(this.btnConversorKelvin);
            this.Controls.Add(this.btnConversorCelsius);
            this.Controls.Add(this.btnConversorFahrenheit);
            this.Controls.Add(this.lblKelvinResultado);
            this.Controls.Add(this.lblCelsiusResultado);
            this.Controls.Add(this.lblFahrenheitResultado);
            this.Controls.Add(this.lblKelvinGrados);
            this.Controls.Add(this.lblCelsiusGrados);
            this.Controls.Add(this.lblFahrenheitGrados);
            this.Name = "FrmConversorTemperatura";
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFahrenheitGrados;
        private Label lblCelsiusGrados;
        private Label lblKelvinGrados;
        private Label lblFahrenheitResultado;
        private Label lblCelsiusResultado;
        private Label lblKelvinResultado;
        private Button btnConversorFahrenheit;
        private Button btnConversorCelsius;
        private Button btnConversorKelvin;
        private TextBox txtBoxFahrenheitGrados;
        private TextBox txtBoxCelsiusGrados;
        private TextBox txtBoxKelvinGrados;
        private TextBox txtBoxFahrenheitAFahrenheit;
        private TextBox txtBoxFahrenheitACelsius;
        private TextBox txtBoxFahrenheitAKelvin;
        private TextBox txtBoxCelsiusAFahrenheit;
        private TextBox txtBoxCelsiusACelsius;
        private TextBox txtBoxCelsiusAKelvin;
        private TextBox txtBoxKelvinAFahrenheit;
        private TextBox txtBoxKelvinACelsius;
        private TextBox txtBoxKelvinAKelvin;
    }
}