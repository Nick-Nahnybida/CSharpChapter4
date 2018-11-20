using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrenheitToCelsius
{
    public partial class frmFahrenheitToCelsius : Form
    {
        public frmFahrenheitToCelsius()
        {
            InitializeComponent();
        }
        private double temp8AM;
        private double tempNoon;
        private double temp5PM;
        private double result8AM;
        private double resultNoon;
        private double result5PM;
        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            picCelsius.Visible = false;
            picFahrenheit.Visible = true;
            lblEnterCelsius.Visible = false;
            lblEnterFahrenheit.Visible = true;
            lblCelsiusResult.Visible = true;
            lblFahrenheitResult.Visible = false;

            temp8AM = Convert.ToDouble(txt8AMInput.Text);
            tempNoon = Convert.ToDouble(txtNoonInput.Text);
            temp5PM = Convert.ToDouble(txt5PMInput.Text);

            result8AM = (temp8AM - 32) / 1.8;
            resultNoon = (tempNoon - 32) / 1.8;
            result5PM = (temp5PM - 32) / 1.8;

            if (result8AM <= 32)
            {
                lbl8AMResult.Text = Math.Round(result8AM, 2) + ", It is freezing outside";
            }
            else if (result8AM >= 32 && result8AM <= 100)
            {
                lbl8AMResult.Text = Math.Round(result8AM, 2) + "";
            }
            else if (result8AM > 100)
            {
                lbl8AMResult.Text = Math.Round(result8AM, 2) + ", It is hot outside";
            }



            if (resultNoon <= 32)
            {
                lblNoonResult.Text = Math.Round(resultNoon, 2) + ", It is freezing outside";
            }
            else if (resultNoon >= 32 && resultNoon <= 100)
            {
                lblNoonResult.Text = Math.Round(resultNoon, 2) + "";
            }
            else if (resultNoon > 100)
            {
                lblNoonResult.Text = Math.Round(resultNoon, 2) + ", It is hot outside";
            }



            if (result5PM <= 32)
            {
                lbl5PMResult.Text = Math.Round(result5PM, 2) + ", It is freezing outside";
            }
            else if (result5PM >= 32 && result5PM <= 100)
            {
                lbl5PMResult.Text = Math.Round(result5PM, 2) + "";
            }
            else if (result5PM > 100)
            {
                lbl5PMResult.Text = Math.Round(result5PM, 2) + ", It is hot outside";
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            picCelsius.Visible = true;
            picFahrenheit.Visible = false;
            lblEnterCelsius.Visible = true;
            lblEnterFahrenheit.Visible = false;
            lblCelsiusResult.Visible = false;
            lblFahrenheitResult.Visible = true;

            temp8AM = Convert.ToDouble(txt8AMInput.Text);
            tempNoon = Convert.ToDouble(txtNoonInput.Text);
            temp5PM = Convert.ToDouble(txt5PMInput.Text);

            result8AM = (temp8AM * 1.8) + 32;
            resultNoon = (tempNoon * 1.8) + 32;
            result5PM = (temp5PM * 1.8) + 32;
            

            
            if (result8AM <= 32)
            {
                lbl8AMResult.Text = Math.Round(result8AM, 2) + ", It is freezing outside";
            }
            else if (result8AM >= 32 && result8AM <= 100)
            {
                lbl8AMResult.Text = Math.Round(result8AM, 2) + "";
            }
            else if (result8AM > 100)
            {
                lbl8AMResult.Text = Math.Round(result8AM, 2) + ", It is hot outside";
            }



            if (resultNoon <= 32)
            {
                lblNoonResult.Text = Math.Round(resultNoon, 2) + ", It is freezing outside";
            }
            else if (resultNoon >= 32 && resultNoon <= 100)
            {
                lblNoonResult.Text = Math.Round(resultNoon, 2) + "";
            }
            else if (resultNoon > 100)
            {
                lblNoonResult.Text = Math.Round(resultNoon, 2) + ", It is hot outside";
            }



            if (result5PM <= 32)
            {
                lbl5PMResult.Text = Math.Round(result5PM, 2) + ", It is freezing outside";
            }
            else if (result5PM >= 32 && result5PM <= 100)
            {
                lbl5PMResult.Text = Math.Round(result5PM, 2) + "";
            }
            else if (result5PM > 100)
            {
                lbl5PMResult.Text = Math.Round(result5PM, 2) + ", It is hot outside";
            }
        }
    }
}
