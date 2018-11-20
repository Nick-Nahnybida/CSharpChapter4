namespace FahrenheitToCelsius
{
    partial class frmFahrenheitToCelsius
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFahrenheitToCelsius));
            this.lbl8AM = new System.Windows.Forms.Label();
            this.lblNoon = new System.Windows.Forms.Label();
            this.lbl5PM = new System.Windows.Forms.Label();
            this.txt8AMInput = new System.Windows.Forms.TextBox();
            this.txtNoonInput = new System.Windows.Forms.TextBox();
            this.txt5PMInput = new System.Windows.Forms.TextBox();
            this.lblEnterFahrenheit = new System.Windows.Forms.Label();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.lbl8AMResult = new System.Windows.Forms.Label();
            this.lblNoonResult = new System.Windows.Forms.Label();
            this.lbl5PMResult = new System.Windows.Forms.Label();
            this.lblCelsiusResult = new System.Windows.Forms.Label();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.picCelsius = new System.Windows.Forms.PictureBox();
            this.picFahrenheit = new System.Windows.Forms.PictureBox();
            this.lblEnterCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheitResult = new System.Windows.Forms.Label();
            this.lbl5PM2 = new System.Windows.Forms.Label();
            this.lblNoon2 = new System.Windows.Forms.Label();
            this.lbl8AM2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCelsius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFahrenheit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl8AM
            // 
            this.lbl8AM.AutoSize = true;
            this.lbl8AM.Location = new System.Drawing.Point(48, 66);
            this.lbl8AM.Name = "lbl8AM";
            this.lbl8AM.Size = new System.Drawing.Size(50, 13);
            this.lbl8AM.TabIndex = 0;
            this.lbl8AM.Text = "8:00 AM:";
            // 
            // lblNoon
            // 
            this.lblNoon.AutoSize = true;
            this.lblNoon.Location = new System.Drawing.Point(65, 119);
            this.lblNoon.Name = "lblNoon";
            this.lblNoon.Size = new System.Drawing.Size(36, 13);
            this.lblNoon.TabIndex = 1;
            this.lblNoon.Text = "Noon:";
            // 
            // lbl5PM
            // 
            this.lbl5PM.AutoSize = true;
            this.lbl5PM.Location = new System.Drawing.Point(51, 165);
            this.lbl5PM.Name = "lbl5PM";
            this.lbl5PM.Size = new System.Drawing.Size(50, 13);
            this.lbl5PM.TabIndex = 2;
            this.lbl5PM.Text = "5:00 PM:";
            // 
            // txt8AMInput
            // 
            this.txt8AMInput.Location = new System.Drawing.Point(133, 66);
            this.txt8AMInput.Name = "txt8AMInput";
            this.txt8AMInput.Size = new System.Drawing.Size(100, 20);
            this.txt8AMInput.TabIndex = 3;
            // 
            // txtNoonInput
            // 
            this.txtNoonInput.Location = new System.Drawing.Point(133, 119);
            this.txtNoonInput.Name = "txtNoonInput";
            this.txtNoonInput.Size = new System.Drawing.Size(100, 20);
            this.txtNoonInput.TabIndex = 4;
            // 
            // txt5PMInput
            // 
            this.txt5PMInput.Location = new System.Drawing.Point(133, 165);
            this.txt5PMInput.Name = "txt5PMInput";
            this.txt5PMInput.Size = new System.Drawing.Size(100, 20);
            this.txt5PMInput.TabIndex = 5;
            // 
            // lblEnterFahrenheit
            // 
            this.lblEnterFahrenheit.AutoSize = true;
            this.lblEnterFahrenheit.Location = new System.Drawing.Point(23, 25);
            this.lblEnterFahrenheit.Name = "lblEnterFahrenheit";
            this.lblEnterFahrenheit.Size = new System.Drawing.Size(215, 13);
            this.lblEnterFahrenheit.TabIndex = 6;
            this.lblEnterFahrenheit.Text = "Temperatures During The Day In Fahrenheit";
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(321, 137);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btnFahrenheit.TabIndex = 7;
            this.btnFahrenheit.Text = "Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // lbl8AMResult
            // 
            this.lbl8AMResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl8AMResult.Location = new System.Drawing.Point(601, 68);
            this.lbl8AMResult.Name = "lbl8AMResult";
            this.lbl8AMResult.Size = new System.Drawing.Size(187, 23);
            this.lbl8AMResult.TabIndex = 8;
            // 
            // lblNoonResult
            // 
            this.lblNoonResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoonResult.Location = new System.Drawing.Point(601, 119);
            this.lblNoonResult.Name = "lblNoonResult";
            this.lblNoonResult.Size = new System.Drawing.Size(187, 23);
            this.lblNoonResult.TabIndex = 9;
            // 
            // lbl5PMResult
            // 
            this.lbl5PMResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl5PMResult.Location = new System.Drawing.Point(601, 165);
            this.lbl5PMResult.Name = "lbl5PMResult";
            this.lbl5PMResult.Size = new System.Drawing.Size(187, 23);
            this.lbl5PMResult.TabIndex = 10;
            // 
            // lblCelsiusResult
            // 
            this.lblCelsiusResult.AutoSize = true;
            this.lblCelsiusResult.Location = new System.Drawing.Point(534, 25);
            this.lblCelsiusResult.Name = "lblCelsiusResult";
            this.lblCelsiusResult.Size = new System.Drawing.Size(120, 13);
            this.lblCelsiusResult.TabIndex = 11;
            this.lblCelsiusResult.Text = "Temperatures In Celsius";
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(417, 137);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnCelsius.TabIndex = 12;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // picCelsius
            // 
            this.picCelsius.Image = ((System.Drawing.Image)(resources.GetObject("picCelsius.Image")));
            this.picCelsius.Location = new System.Drawing.Point(321, 25);
            this.picCelsius.Name = "picCelsius";
            this.picCelsius.Size = new System.Drawing.Size(171, 106);
            this.picCelsius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCelsius.TabIndex = 13;
            this.picCelsius.TabStop = false;
            // 
            // picFahrenheit
            // 
            this.picFahrenheit.Image = ((System.Drawing.Image)(resources.GetObject("picFahrenheit.Image")));
            this.picFahrenheit.Location = new System.Drawing.Point(321, 25);
            this.picFahrenheit.Name = "picFahrenheit";
            this.picFahrenheit.Size = new System.Drawing.Size(171, 106);
            this.picFahrenheit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFahrenheit.TabIndex = 14;
            this.picFahrenheit.TabStop = false;
            // 
            // lblEnterCelsius
            // 
            this.lblEnterCelsius.AutoSize = true;
            this.lblEnterCelsius.Location = new System.Drawing.Point(23, 25);
            this.lblEnterCelsius.Name = "lblEnterCelsius";
            this.lblEnterCelsius.Size = new System.Drawing.Size(198, 13);
            this.lblEnterCelsius.TabIndex = 15;
            this.lblEnterCelsius.Text = "Temperatures During The Day In Celsius";
            // 
            // lblFahrenheitResult
            // 
            this.lblFahrenheitResult.AutoSize = true;
            this.lblFahrenheitResult.Location = new System.Drawing.Point(531, 25);
            this.lblFahrenheitResult.Name = "lblFahrenheitResult";
            this.lblFahrenheitResult.Size = new System.Drawing.Size(137, 13);
            this.lblFahrenheitResult.TabIndex = 16;
            this.lblFahrenheitResult.Text = "Temperatures In Fahrenheit";
            // 
            // lbl5PM2
            // 
            this.lbl5PM2.AutoSize = true;
            this.lbl5PM2.Location = new System.Drawing.Point(537, 172);
            this.lbl5PM2.Name = "lbl5PM2";
            this.lbl5PM2.Size = new System.Drawing.Size(50, 13);
            this.lbl5PM2.TabIndex = 19;
            this.lbl5PM2.Text = "5:00 PM:";
            // 
            // lblNoon2
            // 
            this.lblNoon2.AutoSize = true;
            this.lblNoon2.Location = new System.Drawing.Point(551, 126);
            this.lblNoon2.Name = "lblNoon2";
            this.lblNoon2.Size = new System.Drawing.Size(36, 13);
            this.lblNoon2.TabIndex = 18;
            this.lblNoon2.Text = "Noon:";
            // 
            // lbl8AM2
            // 
            this.lbl8AM2.AutoSize = true;
            this.lbl8AM2.Location = new System.Drawing.Point(534, 73);
            this.lbl8AM2.Name = "lbl8AM2";
            this.lbl8AM2.Size = new System.Drawing.Size(50, 13);
            this.lbl8AM2.TabIndex = 17;
            this.lbl8AM2.Text = "8:00 AM:";
            // 
            // frmFahrenheitToCelsius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 225);
            this.Controls.Add(this.lbl5PM2);
            this.Controls.Add(this.lblNoon2);
            this.Controls.Add(this.lbl8AM2);
            this.Controls.Add(this.lblFahrenheitResult);
            this.Controls.Add(this.lblEnterCelsius);
            this.Controls.Add(this.picFahrenheit);
            this.Controls.Add(this.picCelsius);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.lblCelsiusResult);
            this.Controls.Add(this.lbl5PMResult);
            this.Controls.Add(this.lblNoonResult);
            this.Controls.Add(this.lbl8AMResult);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.lblEnterFahrenheit);
            this.Controls.Add(this.txt5PMInput);
            this.Controls.Add(this.txtNoonInput);
            this.Controls.Add(this.txt8AMInput);
            this.Controls.Add(this.lbl5PM);
            this.Controls.Add(this.lblNoon);
            this.Controls.Add(this.lbl8AM);
            this.Name = "frmFahrenheitToCelsius";
            this.Text = "FahrenheitToCelsius";
            ((System.ComponentModel.ISupportInitialize)(this.picCelsius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFahrenheit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl8AM;
        private System.Windows.Forms.Label lblNoon;
        private System.Windows.Forms.Label lbl5PM;
        private System.Windows.Forms.TextBox txt8AMInput;
        private System.Windows.Forms.TextBox txtNoonInput;
        private System.Windows.Forms.TextBox txt5PMInput;
        private System.Windows.Forms.Label lblEnterFahrenheit;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Label lbl8AMResult;
        private System.Windows.Forms.Label lblNoonResult;
        private System.Windows.Forms.Label lbl5PMResult;
        private System.Windows.Forms.Label lblCelsiusResult;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.PictureBox picCelsius;
        private System.Windows.Forms.PictureBox picFahrenheit;
        private System.Windows.Forms.Label lblEnterCelsius;
        private System.Windows.Forms.Label lblFahrenheitResult;
        private System.Windows.Forms.Label lbl5PM2;
        private System.Windows.Forms.Label lblNoon2;
        private System.Windows.Forms.Label lbl8AM2;
    }
}

