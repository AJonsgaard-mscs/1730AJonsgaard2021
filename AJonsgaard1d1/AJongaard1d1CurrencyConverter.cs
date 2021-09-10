using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJonsgaard1d1
{
    public partial class AJongaard1d1CurrencyConverter : Form
    {
        public AJongaard1d1CurrencyConverter()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = ("0.00");
            txtAmountBhutan.Text = ("0.00");
            txtAmountCostaRica.Text = ("0.00");
            txtAmountEurope.Text = ("0.00");
            txtRateAustralia.Text = ("0.717976");
            txtRateBhutan.Text = ("0.0139831");
            txtRateCotsaRica.Text = ("0.00176122");
            txtRateEurope.Text = ("1.15528");
            txtAmountAustralia.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AustraliaTextChange(object sender, EventArgs e)
        {
            txtAstraliaToUSD.Text = (Convert.ToDecimal(txtAmountAustralia.Text) * 
                Convert.ToDecimal(txtRateAustralia.Text)).ToString("0.00");
        }

        private void BhutanTextChange(object sender, EventArgs e)
        {
            txtBhutanToUSD.Text = (Convert.ToDecimal(txtAmountBhutan.Text) * 
                Convert.ToDecimal(txtRateBhutan.Text)).ToString("0.00");
        }

        private void CostaRicaTextChange(object sender, EventArgs e)
        {
            txtCostaRicaToUSD.Text = (Convert.ToDecimal(txtAmountCostaRica.Text) * 
                Convert.ToDecimal(txtRateCotsaRica.Text)).ToString("0.00");
        }

        private void EuropeanTextChange(object sender, EventArgs e)
        {
            txtEuropeToUSD.Text = (Convert.ToDecimal(txtAmountEurope.Text) * 
                Convert.ToDecimal(txtRateEurope.Text)).ToString("0.00");
        }

        private void USTotalTextChange(object sender, EventArgs e)
        {
            txtUSTotal.Text = (Convert.ToDecimal(txtAstraliaToUSD.Text) +
                Convert.ToDecimal(txtBhutanToUSD.Text) +
                Convert.ToDecimal(txtCostaRicaToUSD.Text) +
                Convert.ToDecimal(txtEuropeToUSD.Text)).ToString("0.00");
        }
    }
}
