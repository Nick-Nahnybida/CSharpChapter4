namespace DailySpecial
{
    partial class Form1
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
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.lblForExample = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.specialButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(44, 20);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(185, 13);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Enter a day number to see our special";
            // 
            // lblForExample
            // 
            this.lblForExample.AutoSize = true;
            this.lblForExample.Location = new System.Drawing.Point(71, 52);
            this.lblForExample.Name = "lblForExample";
            this.lblForExample.Size = new System.Drawing.Size(124, 13);
            this.lblForExample.TabIndex = 1;
            this.lblForExample.Text = "For example, Sunday = 1";
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(85, 81);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(100, 20);
            this.dayBox.TabIndex = 2;
            // 
            // specialButton
            // 
            this.specialButton.Location = new System.Drawing.Point(96, 122);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(75, 23);
            this.specialButton.TabIndex = 3;
            this.specialButton.Text = "Get special";
            this.specialButton.UseVisualStyleBackColor = true;
            this.specialButton.Click += new System.EventHandler(this.specialButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(34, 166);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(205, 23);
            this.outputLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 224);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.lblForExample);
            this.Controls.Add(this.lblEnterNumber);
            this.Name = "Form1";
            this.Text = "DailySpecial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.Label lblForExample;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Button specialButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

