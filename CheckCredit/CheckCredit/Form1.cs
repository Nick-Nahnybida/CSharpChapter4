using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCredit
{
    public partial class frmCheckCredit : Form
    {
        public frmCheckCredit()
        {
            InitializeComponent();
        }

        private void btnCheckCredit_Click(object sender, EventArgs e)
        {
            double Price;

            Price = Convert.ToDouble(txtEnterPrice.Text);

            if (Price > 5000)
            {
                lblResult.Text = "ERROR: Price too high";
            }
            else
            {
                lblResult.Text = "Approved";
            }
        }
    }
}
