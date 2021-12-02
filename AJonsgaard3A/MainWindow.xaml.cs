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

namespace AJonsgaard3A
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
            ResultTextbox0.Text = Ex3aLoops.Calc0(InputTextbox0A.Text, InputTextbox0B.Text, InputTextbox0C.Text);
            ResultTextbox1.Text = Ex3aLoops.Calc1(InputTextbox1A.Text, InputTextbox1B.Text, InputTextbox1C.Text);
            ResultTextbox2.Text = Ex3aLoops.Calc2(InputTextbox2A.Text, InputTextbox2B.Text, InputTextbox2C.Text);
            ResultTextbox3.Text = Ex3aLoops.Calc3(InputTextbox3A.Text, InputTextbox3B.Text, InputTextbox3C.Text);
            ResultTextbox4.Text = Ex3aLoops.Calc4(InputTextbox4A.Text, InputTextbox4B.Text, InputTextbox4C.Text);
            ResultTextbox5.Text = Ex3aLoops.Calc5(InputTextbox5A.Text, InputTextbox5B.Text, InputTextbox5C.Text);
            ResultTextbox6.Text = Ex3aLoops.Calc6(InputTextbox6A.Text, InputTextbox6B.Text);
            ResultTextbox7.Text = Ex3aLoops.Calc7(InputTextbox7A.Text, InputTextbox7B.Text);
            ResultTextbox8.Text = Ex3aLoops.Calc8(InputTextbox8A.Text, InputTextbox8B.Text);
        }
    }
}
