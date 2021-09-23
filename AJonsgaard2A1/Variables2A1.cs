using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJonsgaard2A1
{
    public partial class Variables2A1 : Form
    {
        public Variables2A1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            txtSubtotal.Text = subtotal.ToString("0.00");
            decimal discountP = (Convert.ToDecimal(txtDiscountPercent.Text) / 100);
            txtDiscountPercent.Text = txtDiscountPercent.Text;
            decimal discountA = subtotal * discountP;
            txtDicountAmount.Text = discountA.ToString("0.00");
            decimal total = subtotal - discountA;
            txtTotal.Text = total.ToString("0.00");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
