using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730AJonsgaard1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                4.0m * Convert.ToInt32(txtHotDogs.Text)
                ).ToString("0.00");
            txtHamburgersSubtotal.Text = (
                5.0m * Convert.ToInt32(txtHamburgers.Text)
                ).ToString("0.00");
            txtPretaxtotal.Text = (
                Convert.ToDecimal(txtHotDogsSubtotal.Text) +
                Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString("0.00");
            txtTax.Text = 
                (Convert.ToDecimal(txtPretaxtotal.Text) * 
                Convert.ToDecimal(0.06875)
                ).ToString("0.00");
            txtTotal.Text =
                (Convert.ToDecimal(txtPretaxtotal.Text) +
                Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");
            btnClear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtHotDogs.Focus();


        }
    }
}
