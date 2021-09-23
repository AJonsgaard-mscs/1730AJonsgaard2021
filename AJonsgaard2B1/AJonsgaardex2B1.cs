using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJonsgaard2B1
{
    public partial class AJonsgaardex2B1 : Form
    {
        public AJonsgaardex2B1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal australiaAmount = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal australiaRate = Convert.ToDecimal(txtRateAustralia.Text);
            decimal australiaToUSD = australiaAmount * australiaRate;
            txtAstraliaToUSD.Text = australiaToUSD.ToString("0.00");

            decimal bhutanAmount = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal bhutanRate = Convert.ToDecimal(txtRateBhutan.Text);
            decimal bhutanToUSD = bhutanAmount * bhutanRate;
            txtBhutanToUSD.Text = bhutanToUSD.ToString("0.00");

            decimal costaRicoAmount = Convert.ToDecimal(txtAmountCostaRica.Text);
            decimal costaRicoRate = Convert.ToDecimal(txtRateCotsaRica.Text);
            decimal CostaRicoToUSD = costaRicoAmount * costaRicoRate;
            txtCostaRicaToUSD.Text = CostaRicoToUSD.ToString("0.00");

            decimal europeAmount = Convert.ToDecimal(txtAmountEurope.Text);
            decimal europeRate = Convert.ToDecimal(txtRateEurope.Text);
            decimal europeToUSD = europeAmount + europeRate;
            txtEuropeToUSD.Text = europeToUSD.ToString("0.00");

            decimal totalUSD = bhutanToUSD + australiaToUSD + CostaRicoToUSD + europeToUSD;
            txtUSTotal.Text = totalUSD.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
