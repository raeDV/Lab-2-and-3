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

namespace BankCharges
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double input1 = Convert.ToDouble(balance.Text);
            double input2 = Convert.ToDouble(checks.Text);
            int monthlyFee = 10;
            int extraCharge = 15;

            if (input1 < 400)
            {
                if (input2 < 20)
                {
                    monthlyCharge.Text = "$" + Convert.ToString((input2 * 0.1) + extraCharge + monthlyFee);
                }
                else if (input2 >= 20 && input2 <= 39)
                {
                    monthlyCharge.Text = "$" + Convert.ToString((input2 * 0.08) + extraCharge + monthlyFee);
                }
                else if (input2 >= 40 && input2 <= 59)
                {
                    monthlyCharge.Text = "$" + Convert.ToString((input2 * 0.06) + extraCharge + monthlyFee);
                }
                else if (input2 >= 60)
                {
                    monthlyCharge.Text = "$" + Convert.ToString((input2 * 0.04) + extraCharge + monthlyFee);
                }
            }
            else //balance is greater than 400
            {
                if (input2 < 20)
                {
                    monthlyCharge.Text = "$" + Convert.ToString((input2 * 0.1) + monthlyFee);
                }
                else if (input2 >= 20 && input2 <= 39)
                {
                    monthlyCharge.Text = "$" + Convert.ToString((input2 * 0.08) + monthlyFee);
                }
                else if (input2 >= 40 && input2 <= 59)
                {
                    monthlyCharge.Text = "$" + Convert.ToString((input2 * 0.06) + monthlyFee);
                }
                else if (input2 >= 60)
                {
                    monthlyCharge.Text = "$" + Convert.ToString((input2 * 0.04) + monthlyFee);
                }
            }
        }
    }
    
}
