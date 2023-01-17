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

namespace TestScores
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
            double input1 = Convert.ToDouble(num1.Text);
            double input2 = Convert.ToDouble(num2.Text);
            double input3 = Convert.ToDouble(num3.Text);

            double courseAvg = ((input1 + input2 + input3) / 3);

            if (courseAvg >= 90 && courseAvg <= 100)
            {
                result.Text = "A - " + Convert.ToString(courseAvg) + "%";
            }
            else if (courseAvg >= 80 && courseAvg <= 89)
            {
                result.Text = "B - " + Convert.ToString(courseAvg) + "%";
            }
            else if (courseAvg >= 70 && courseAvg <= 79)
            {
                result.Text = "C - " + Convert.ToString(courseAvg) + "%";
            }
            else if (courseAvg >= 60 && courseAvg <= 69)
            {
                result.Text = "D - " + Convert.ToString(courseAvg) + "%";
            }
            else
            {
                result.Text = "Fail - " + Convert.ToString(courseAvg) + "%";
            }
        }
    }
}
