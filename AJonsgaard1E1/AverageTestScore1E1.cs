using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJonsgaard1E1
{
    public partial class AverageTestScore1E1 : Form
    {
        public AverageTestScore1E1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = ((Convert.ToDecimal(txtTest1.Text) +
                Convert.ToDecimal(txtTest2.Text) +
                Convert.ToDecimal(txtTest3.Text)) / 3).ToString("0.00");
            btnClear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = ("0");
            txtTest2.Text = ("0");
            txtTest3.Text = ("0");
            txtAverage.Text = ("");
            txtTest1.Focus();
        }
    }
}
