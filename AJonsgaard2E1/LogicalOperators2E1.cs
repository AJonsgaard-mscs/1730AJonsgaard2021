using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJonsgaard2E1
{
    public partial class LogicalOperators2E1 : Form
    {
        public LogicalOperators2E1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            re01Textbox.Text = "";
            re02Textbox.Text = "";
            re03Textbox.Text = "";
            re04Textbox.Text = "";
            re05Textbox.Text = "";
            re06Textbox.Text = "";
            re07Textbox.Text = "";
            re08Textbox.Text = "";
            re09Textbox.Text = "";
            re10Textbox.Text = "";
            SE03Textbox.Text = "";
            SE04Textbox.Text = "";
            SE05Textbox.Text = "";
            SE06Textbox.Text = "";
            SE09Textbox.Text = "";

            // #01
            decimal subtotal = Convert.ToDecimal(in01ATextbox.Text);
            re01Textbox.Text = (subtotal >= 250 && subtotal <500).ToString();

            // #02
            int timeInService = Convert.ToInt32(in02Textbox.Text);
            re02Textbox.Text = (timeInService <= 4 || timeInService >= 12).ToString();

            // #03 - 06 initialization
            bool isValid = Convert.ToBoolean(in03TextboxA.Text);
            int years = Convert.ToInt32(in03TextboxC.Text);

            // #03
            int counter = Convert.ToInt32(in03TextboxB.Text);
            re03Textbox.Text = (isValid == true && counter++ < years).ToString();
            SE03Textbox.Text = counter.ToString();

            // #04
            counter = Convert.ToInt32(in03TextboxB.Text);
            re04Textbox.Text = (isValid == true & counter++ < years).ToString();
            SE04Textbox.Text = counter.ToString();

            // #05
            counter = Convert.ToInt32(in03TextboxB.Text);
            re05Textbox.Text = (isValid == true || counter++ < years).ToString();
            SE05Textbox.Text = counter.ToString();

            // #06
            counter = Convert.ToInt32(in03TextboxB.Text);
            re06Textbox.Text = (isValid == true | counter++ < years).ToString();
            SE06Textbox.Text = counter.ToString();

            // #07
            DateTime startDate = Convert.ToDateTime(in07TextboxA.Text);
            DateTime expirationDate = Convert.ToDateTime(in07TextboxB.Text);
            DateTime date = Convert.ToDateTime(in07TextboxC.Text);
            isValid = Convert.ToBoolean(in07TextboxD.Text);
            re07Textbox.Text = (date > startDate && date < expirationDate || isValid == true).ToString();

            // #08
            decimal thisYTD = Convert.ToDecimal(in08TextboxA.Text);
            decimal lastYTD = Convert.ToDecimal(in08TextboxB.Text);
            string empType = in08TextboxC.Text;
            int startYear = Convert.ToInt32(in08TextboxD.Text);
            int currentYear = Convert.ToInt32(in08TextboxE.Text);
            re08Textbox.Text = (((thisYTD > lastYTD) || empType == "Past time") && startYear < currentYear).ToString();

            // #09
            counter = Convert.ToInt32(in09TextboxA.Text);
            years = Convert.ToInt32(in09TextboxB.Text);
            re09Textbox.Text = (!(counter++ >= years)).ToString();
            SE09Textbox.Text = counter.ToString();

            // #10
            int a = Convert.ToInt32(in10TextboxA.Text);
            int b = Convert.ToInt32(in10TextboxB.Text);
            int c = Convert.ToInt32(in10TextboxC.Text);
            int d = Convert.ToInt32(in10TextboxD.Text);
            //re10Textbox.Text = (a + b * c - d).ToString();
            //int x = b * c;
            //int y = a + x;
            //int z = y - d;
            //re10Textbox.Text = z.ToString();
            //re10Textbox.Text = (a > b && b < c || c < d).ToString();
            bool v = a > b;
            bool w = b < c;
            bool x = c < d;
            bool y = v && w;
            bool z = y || x;
            re10Textbox.Text = z.ToString();

            

        }
    }
}
