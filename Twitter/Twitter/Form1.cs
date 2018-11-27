﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter
{
    public partial class frmTwitter : Form
    {
        public frmTwitter()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string message;
            const int MAX = 140;

            message = txtTwitterMsg.Text;

            if (message.Length >= MAX)
            {
                lblCounter.Text = message.Length + " OVER LIMIT";
                lblCounter.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                lblCounter.Text = message.Length + " Under Limit";
                lblCounter.ForeColor = System.Drawing.Color.Black;
                lblPostedMsg.Text = "Posted to Twitter";
            }
        }
    }
}
