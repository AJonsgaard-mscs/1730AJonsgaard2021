using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJonsgaard1F1
{
    public partial class AJonsgaardCurrencyExchangeV2 : Form
    {
        public AJonsgaardCurrencyExchangeV2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            lblCurrency.Text = (":");
            lblCurrency.Text = btnAustralia.Text + lblCurrency.Text;
            txtExchangeRate.Text = ("0.717976");
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = (":");
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            lblCurrency.Text = btnAustralia.Text + lblCurrency.Text;
            txtUSDTotal.Text = ("0.00");
            txtUSD.Text = ("0.00");
            txtExchangeRate.Text = ("0.717976");
            USDEquation.Text = ("");
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            lblCurrency.Text = (":");
            lblCurrency.Text = btnBhutan.Text + lblCurrency.Text;
            txtExchangeRate.Text = ("0.0139831");
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            lblCurrency.Text = (":");
            lblCurrency.Text = btnAustralia.Text + lblCurrency.Text;
            txtExchangeRate.Text = ("0.717976");
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            lblCurrency.Text = (":");
            lblCurrency.Text = btnCostaRica.Text + lblCurrency.Text;
            txtExchangeRate.Text = ("0.00176122");
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
        }

        private void btnEurope_Click(object sender, EventArgs e)
        {
            btnEurope.BackgroundImage = picEurope.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            lblCurrency.Text = (":");
            lblCurrency.Text = btnEurope.Text + lblCurrency.Text;
            txtExchangeRate.Text = ("1.15528");
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
        }

        private void CalcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (Convert.ToDecimal(txtCurrency.Text) *
               Convert.ToDecimal(txtExchangeRate.Text)).ToString("0.00");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            USDEquation.Text = USDEquation.Text + " + " + txtUSD.Text;
            txtUSDTotal.Text = (Convert.ToDecimal(txtUSDTotal.Text) +
                Convert.ToDecimal(txtUSD.Text)).ToString("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }
    }
}
