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

namespace ShippingCharges
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

        private void shippingFee_Click(object sender, RoutedEventArgs e)
        {
            double input1 = Convert.ToDouble(weight.Text);
            double input2 = Convert.ToDouble(distance.Text);

            if (input2 <= 500)
            {
                if (input1 <= 2)
                {
                    result.Text = "$" + Convert.ToString(1.1);
                }
                else if (input1 > 2 && input1 <= 6)
                {
                    result.Text = "$" + Convert.ToString(2.2);
                }
                else if (input1 > 6 && input1 <= 10)
                {
                    result.Text = "$" + Convert.ToString(3.7);
                }
                else if (input1 > 10)
                {
                    result.Text = "$" + Convert.ToString(4.8);
                }
            }
            else //miles is greater than 500
            {
                if (input1 <= 2)
                {
                    result.Text = "$" + Convert.ToString(1.1 * 2);
                }
                else if (input1 > 2 && input1 <= 6)
                {
                    result.Text = "$" + Convert.ToString(2.2 * 2);
                }
                else if (input1 > 6 && input1 <= 10)
                {
                    result.Text = "$" + Convert.ToString(3.7 * 2);
                }
                else if (input1 > 10)
                {
                    result.Text = "$" + Convert.ToString(4.8 * 2);
                }

            }
        }
    }
}
