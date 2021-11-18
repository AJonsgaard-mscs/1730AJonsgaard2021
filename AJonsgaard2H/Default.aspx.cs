using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AJonsgaard2H
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DateCalculationsButton_Click(object sender, EventArgs e)
        {
            // 1) Now
            TextBox1aResult.Text = DateTime.Now.ToShortDateString();
            TextBox1bResult.Text = DateTime.Now.ToShortTimeString();

            // 2) Today
            TextBox2aResult.Text = DateTime.Today.ToShortDateString();
            TextBox2bResult.Text = DateTime.Today.ToShortTimeString();

            // 3) Year, Month, Day
            TextBox3aResult.Text = DateTime.Today.Year.ToString();
            TextBox3bResult.Text = DateTime.Today.Month.ToString();
            TextBox3cResult.Text = DateTime.Today.Day.ToString();

            // 4) Add Days
            TextBox4Result.Text = DateTime.Today.AddDays(90).ToShortDateString();

            // 5) Add Months
            TextBox5Result.Text = DateTime.Today.AddMonths(3).ToShortDateString();

            // 6) Year, Month, Day String
            TextBox6Reault.Text = Ex2hCalculations.DateCalc06(TextBox6aInput.Text, TextBox6bInput.Text, TextBox6cInput.Text);

            // 7) 
            TextBox7Reault.Text = Ex2hCalculations.DateCalc07(TextBox7.Text);

            // 8)
            TextBox8Reault.Text = Ex2hCalculations.DateCalc08(TextBox8.Text);

            // 9)
            TextBox9Reault.Text = Ex2hCalculations.DateCalc09(TextBox9a.Text, TextBox9b.Text);

            // 10) 
            TextBox10Reault.Text = Ex2hCalculations.DateCalc10(TextBox10a.Text, TextBox10b.Text);
        }
        
    }
}