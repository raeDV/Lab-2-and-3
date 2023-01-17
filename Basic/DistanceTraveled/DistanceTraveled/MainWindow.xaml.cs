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

namespace DistanceTraveled
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
            StringBuilder sb = new StringBuilder("Hours\tDistance\n");
            double input1 = Convert.ToDouble(hours.Text);
            double input2 = Convert.ToDouble(miles.Text);
            for (int i = 1; i <= input1; i++)
            {
                string str = i + "\t" + (input2*i).ToString() + "\n";
                sb.Append(str);

            }
            result.Text = sb.ToString();

        }
    }
}
