using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJonsgaard2G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1a) 'Switch' with no default
            resultSwitch01textBox.Text = Ex2GCalculations.Switch01(input1atextBox.Text);

            // 1b) Separate 'if' statements
            resultif02textBox.Text = Ex2GCalculations.If01(input1atextBox.Text);

            // 1c) if else-if
            resultelseif03textbox.Text = Ex2GCalculations.ElseIf01(input1atextBox.Text);

            // 1d) Nested if-else
            resultnetedifelse04textBox.Text = Ex2GCalculations.NestedIf01(input1atextBox.Text);

            // 1e) 'Switch' with default
            resultswitchdefault05textBox.Text = Ex2GCalculations.SwitchDefault01(input1atextBox.Text);

            // 1f) Separate 'if' statements w/default
            resultif06textBox.Text = Ex2GCalculations.IfDefault01(input1atextBox.Text);

            // 1g) if else-if w/default
            resultelseif07textbox.Text = Ex2GCalculations.ElseIfDefault01(input1atextBox.Text);

            // 1h) Nested if-else w/default
            resultnetedifelse08textBox.Text = Ex2GCalculations.NestedIfDefault01(input1atextBox.Text);

            // 2a) 'Switch' with no default
            resaultSwitchT09textBox.Text = Ex2GCalculations.Switch02(input2atextBox.Text);

            // 2b) Seperate 'if' statments
            resultIfT10textBox.Text = Ex2GCalculations.If02(input2atextBox.Text);

            // 2c) if elseif
            resultEsleIfT11textBox.Text = Ex2GCalculations.ElseIf02(input2atextBox.Text);

            // 2d) Nested if-else
            resultNestedT12textBox.Text = Ex2GCalculations.NestedIfElse02(input2atextBox.Text);
        }
    }
}
