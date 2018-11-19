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
            this.lbl8AM = new System.Windows.Forms.Label();
            this.lblNoon = new System.Windows.Forms.Label();
            this.lbl5PM = new System.Windows.Forms.Label();
            this.txt8AMInput = new System.Windows.Forms.TextBox();
            this.txtNoonInput = new System.Windows.Forms.TextBox();
            this.txt5PMInput = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbl8AMResult = new System.Windows.Forms.Label();
            this.lblNoonResult = new System.Windows.Forms.Label();
            this.lbl5PMResult = new System.Windows.Forms.Label();
            this.lblCelsiusTitle = new System.Windows.Forms.Label();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(23, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Please enter the temps in Fahrenheit for these times of day";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(330, 119);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lbl8AMResult
            // 
            this.lbl8AMResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl8AMResult.Location = new System.Drawing.Point(426, 68);
            this.lbl8AMResult.Name = "lbl8AMResult";
            this.lbl8AMResult.Size = new System.Drawing.Size(100, 23);
            this.lbl8AMResult.TabIndex = 8;
            // 
            // lblNoonResult
            // 
            this.lblNoonResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoonResult.Location = new System.Drawing.Point(426, 119);
            this.lblNoonResult.Name = "lblNoonResult";
            this.lblNoonResult.Size = new System.Drawing.Size(100, 23);
            this.lblNoonResult.TabIndex = 9;
            // 
            // lbl5PMResult
            // 
            this.lbl5PMResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl5PMResult.Location = new System.Drawing.Point(426, 165);
            this.lbl5PMResult.Name = "lbl5PMResult";
            this.lbl5PMResult.Size = new System.Drawing.Size(100, 23);
            this.lbl5PMResult.TabIndex = 10;
            // 
            // lblCelsiusTitle
            // 
            this.lblCelsiusTitle.AutoSize = true;
            this.lblCelsiusTitle.Location = new System.Drawing.Point(426, 25);
            this.lblCelsiusTitle.Name = "lblCelsiusTitle";
            this.lblCelsiusTitle.Size = new System.Drawing.Size(106, 13);
            this.lblCelsiusTitle.TabIndex = 11;
            this.lblCelsiusTitle.Text = "The temps in celsius:";
            // 
            // frmFahrenheitToCelsius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCelsiusTitle);
            this.Controls.Add(this.lbl5PMResult);
            this.Controls.Add(this.lblNoonResult);
            this.Controls.Add(this.lbl8AMResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txt5PMInput);
            this.Controls.Add(this.txtNoonInput);
            this.Controls.Add(this.txt8AMInput);
            this.Controls.Add(this.lbl5PM);
            this.Controls.Add(this.lblNoon);
            this.Controls.Add(this.lbl8AM);
            this.Name = "frmFahrenheitToCelsius";
            this.Text = "FahrenheitToCelsius";
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbl8AMResult;
        private System.Windows.Forms.Label lblNoonResult;
        private System.Windows.Forms.Label lbl5PMResult;
        private System.Windows.Forms.Label lblCelsiusTitle;
    }
}

