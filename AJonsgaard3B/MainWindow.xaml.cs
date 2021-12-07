using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AJonsgaard3B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Button_Click(object sender, RoutedEventArgs e)
        {
            // 0) Calculate DiscountPercent
            try
            {
                decimal subtotal = Decimal.Parse(this.InputTextbox0A.Text);
                decimal DiscountPercent = Ex3BCalculations.GetDiscountPercent(subtotal);
                ResultTextbox0.Text = DiscountPercent.ToString("f3");
            }
            catch
            {
                ResultTextbox0.Text = "";
                MessageBox.Show("Invalid Input: " + this.InputTextbox0A.Text);
            }
            // 2) Calculate Future Value
            try
            {
                int Months = Int32.Parse(this.InputTextbox2A.Text);
                decimal MonthlyInvestment = Decimal.Parse(this.InputTextbox2B.Text);
                decimal MonthlyTnterestRare = Decimal.Parse(this.InputTextbox2C.Text);
                decimal FutureValue = Ex3BCalculations.CalculateFutureValue(MonthlyInvestment, MonthlyTnterestRare, Months);
                ResultTextbox2.Text = FutureValue.ToString("c2");
            }
            catch
            {
                ResultTextbox2.Text = "";
                MessageBox.Show("Invalid Input:\n"
                    + this.InputTextbox2A.Text + "\n"
                    + this.InputTextbox2B.Text + "\n"
                    + this.InputTextbox2C.Text);
            }
            // 3) Calculate Future Value using ref argument
            try
            {
                int Months = Int32.Parse(this.InputTextbox3A.Text);
                decimal MonthlyInvestment = Decimal.Parse(this.InputTextbox3B.Text);
                decimal MonthlyTnterestRare = Decimal.Parse(this.InputTextbox3C.Text);
                decimal FutureValue = 0m;
                Ex3BCalculations.CalculateFutureValue(MonthlyInvestment, MonthlyTnterestRare, Months, ref FutureValue);
                ResultTextbox3.Text = FutureValue.ToString("c2");
            }
            catch
            {
                ResultTextbox3.Text = "";
                MessageBox.Show("Invalid Input:\n"
                    + this.InputTextbox3A.Text + "\n"
                    + this.InputTextbox3B.Text + "\n"
                    + this.InputTextbox3C.Text);
            }
            // 4) Calculate Degress Celsius
            try
            {
                double Fahrenheit = Double.Parse(this.InputTextbox4A.Text);
                double Celsius = Ex3BCalculations.FahrenheitToCelsius(Fahrenheit);
                ResultTextbox4.Text = Celsius.ToString("f1");
            }
            catch
            {
                ResultTextbox4.Text = "";
                MessageBox.Show("Invalid Input: " + this.InputTextbox4A.Text);
            }
            // 6) Gross Pay
            try
            {
                decimal Hours = Decimal.Parse(this.InputTextbox6A.Text);
                decimal Rate = Decimal.Parse(this.InputTextbox6B.Text);
                decimal FutureValue = Ex3BCalculations.GrossPay(Hours, Rate);
                ResultTextbox6.Text = FutureValue.ToString("c2");
            }
            catch
            {
                ResultTextbox6.Text = "";
                MessageBox.Show("Invalid Input:\n"
                    + this.InputTextbox6A.Text + "\n"
                    + this.InputTextbox6B.Text);
            }
            // 7) Total Hours 
            try
            {
                this.ResultTextbox7.Text =
                    Ex3BCalculations.TotalHours(this.InputTextbox7A.Text).ToString("n2");
            }
            catch
            {
                ResultTextbox7.Text = "";
                MessageBox.Show("Invalid Input: " + this.InputTextbox7A.Text);
            }
            // 8) Gross Pay String
            try
            {
                decimal rate = Decimal.Parse(this.InputTextbox8B.Text);
                this.ResultTextbox8.Text =
                    Ex3BCalculations.TotalHours(this.InputTextbox8A.Text).ToString("c2");
            }
            catch
            {
                ResultTextbox7.Text = "";
                MessageBox.Show("Invalid Input: " + "\n"
                    + this.InputTextbox8A.Text
                    + "\n" + this.InputTextbox8B.Text);

            }
        }
    }
}
