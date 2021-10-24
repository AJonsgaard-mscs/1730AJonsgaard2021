using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJonsgaard2F_if_if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // #1: if
            result1textbox.Text = Ex2fCalculations.Calc01(input1Atextbox.Text);

            // #2: if {block}
            result2textbox.Text = Ex2fCalculations.Calc02(input2Atextbox.Text);

            // #3: if else
            result3textbox.Text = Ex2fCalculations.Calc03(input3Atextbox.Text);

            // #4: if else if
            result4textbox.Text = Ex2fCalculations.Calc04(input4Atextbox.Text);

            // #5: Better range test
            result5textbox.Text = Ex2fCalculations.Calc05(input5Atextbox.Text);

            // #6 Nested if statement
            result6textbox.Text = Ex2fCalculations.Calc06(input6Atextbox.Text, input6Btextbox.Text);

            // #7 Input Validation
            result7textbox.Text = Ex2fCalculations.Calc07(input7Atextbox.Text);

            // #8 Price, Quantity and Shipping
            result8textbox.Text = Ex2fCalculations.Calc08(input8Atextbox.Text, input8Btextbox.Text);

            // #9 Difference * Rate
            result9textbox.Text = Ex2fCalculations.Calc09(input9Atextbox.Text, input9Btextbox.Text);

            // #10 Divide Large
            result10textbox.Text = Ex2fCalculations.Calc10(input10Atextbox.Text, input10Btextbox.Text);
        }
    }
}
