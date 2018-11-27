namespace CheckCredit
{
    partial class frmCheckCredit
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
            this.lblEnterPrice = new System.Windows.Forms.Label();
            this.txtEnterPrice = new System.Windows.Forms.TextBox();
            this.btnCheckCredit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterPrice
            // 
            this.lblEnterPrice.AutoSize = true;
            this.lblEnterPrice.Location = new System.Drawing.Point(14, 11);
            this.lblEnterPrice.Name = "lblEnterPrice";
            this.lblEnterPrice.Size = new System.Drawing.Size(82, 13);
            this.lblEnterPrice.TabIndex = 0;
            this.lblEnterPrice.Text = "Purchase Price:";
            // 
            // txtEnterPrice
            // 
            this.txtEnterPrice.Location = new System.Drawing.Point(124, 11);
            this.txtEnterPrice.Name = "txtEnterPrice";
            this.txtEnterPrice.Size = new System.Drawing.Size(100, 20);
            this.txtEnterPrice.TabIndex = 1;
            // 
            // btnCheckCredit
            // 
            this.btnCheckCredit.Location = new System.Drawing.Point(124, 68);
            this.btnCheckCredit.Name = "btnCheckCredit";
            this.btnCheckCredit.Size = new System.Drawing.Size(100, 23);
            this.btnCheckCredit.TabIndex = 2;
            this.btnCheckCredit.Text = "Check Credit";
            this.btnCheckCredit.UseVisualStyleBackColor = true;
            this.btnCheckCredit.Click += new System.EventHandler(this.btnCheckCredit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(47, 114);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(177, 23);
            this.lblResult.TabIndex = 3;
            // 
            // frmCheckCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 152);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckCredit);
            this.Controls.Add(this.txtEnterPrice);
            this.Controls.Add(this.lblEnterPrice);
            this.Name = "frmCheckCredit";
            this.Text = "Check Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterPrice;
        private System.Windows.Forms.TextBox txtEnterPrice;
        private System.Windows.Forms.Button btnCheckCredit;
        private System.Windows.Forms.Label lblResult;
    }
}

