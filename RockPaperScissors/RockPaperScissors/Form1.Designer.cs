namespace RockPaperScissors
{
    partial class frmRockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRockPaperScissors));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblChooseOne = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.lblWinTitle = new System.Windows.Forms.Label();
            this.lblLossesTitle = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.Location = new System.Drawing.Point(42, 58);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(220, 186);
            this.btnRock.TabIndex = 0;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.Location = new System.Drawing.Point(290, 58);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(203, 186);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissors.BackgroundImage")));
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissors.Location = new System.Drawing.Point(518, 58);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(213, 186);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblChooseOne
            // 
            this.lblChooseOne.AutoSize = true;
            this.lblChooseOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseOne.Location = new System.Drawing.Point(304, 9);
            this.lblChooseOne.Name = "lblChooseOne";
            this.lblChooseOne.Size = new System.Drawing.Size(189, 37);
            this.lblChooseOne.TabIndex = 3;
            this.lblChooseOne.Text = "Choose one";
            // 
            // lblWinLose
            // 
            this.lblWinLose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWinLose.Location = new System.Drawing.Point(290, 286);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(203, 23);
            this.lblWinLose.TabIndex = 4;
            // 
            // lblWinTitle
            // 
            this.lblWinTitle.AutoSize = true;
            this.lblWinTitle.Location = new System.Drawing.Point(136, 271);
            this.lblWinTitle.Name = "lblWinTitle";
            this.lblWinTitle.Size = new System.Drawing.Size(34, 13);
            this.lblWinTitle.TabIndex = 5;
            this.lblWinTitle.Text = "Wins:";
            // 
            // lblLossesTitle
            // 
            this.lblLossesTitle.AutoSize = true;
            this.lblLossesTitle.Location = new System.Drawing.Point(599, 271);
            this.lblLossesTitle.Name = "lblLossesTitle";
            this.lblLossesTitle.Size = new System.Drawing.Size(40, 13);
            this.lblLossesTitle.TabIndex = 6;
            this.lblLossesTitle.Text = "Losses";
            // 
            // lblWins
            // 
            this.lblWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWins.Location = new System.Drawing.Point(100, 300);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(100, 23);
            this.lblWins.TabIndex = 7;
            // 
            // lblLosses
            // 
            this.lblLosses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLosses.Location = new System.Drawing.Point(568, 300);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(100, 23);
            this.lblLosses.TabIndex = 8;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 363);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblLossesTitle);
            this.Controls.Add(this.lblWinTitle);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.lblChooseOne);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblChooseOne;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Label lblWinTitle;
        private System.Windows.Forms.Label lblLossesTitle;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
    }
}

