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

namespace Home
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] Operations { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            Operations = new string[] { "Banks Charges", "Shipping Charges", "Test Scores", "Distance Traveled" };
            DataContext = this;

        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            if ((String)comboBox.SelectedValue == "Banks Charges")
            {
                BankCharges bankCharges = new BankCharges();
                bankCharges.Show();
            }
            else if ((String)comboBox.SelectedValue == "Shipping Charges")
            {
                ShippingCharges shippingCharges = new ShippingCharges();
                shippingCharges.Show();
            }
            else if ((String)comboBox.SelectedValue == "Test Scores")
            {
                TestScores testScores = new TestScores();
                testScores.Show();
            }
            else if ((String)comboBox.SelectedValue == "Distance Traveled")
            {
                DistanceTraveled distanceTraveled = new DistanceTraveled();
                distanceTraveled.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
