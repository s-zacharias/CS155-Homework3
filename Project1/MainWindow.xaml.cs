using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Note: Please make sure to input a payment that exceeds the amount of interest to be paid. Otherwise, you will not be making progress towards paying off your principle.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double payment, balance, interestRate, principle, interest;
            String alert = "";

            payment = Double.Parse(monthlyPayment.Text);
            balance = Double.Parse(outstandingBalance.Text);
            interestRate = 0.0639;

            // determine the interest portion
            interest = (balance * interestRate) / 12;

            // determine the principle portion
            principle = payment - interest;

            // cover the case where the payment is too low
            if (interest >= payment)
            {
                interest = payment;
                principle = 0;
                alert = "Please increase your payment to avoid underpaying!";
            }

            // display breakdown
            MessageBox.Show("Your payment breakdown is: \nPrinciple: "
                + principle.ToString("C", CultureInfo.CurrentCulture) + "\nInterest: " 
                + interest.ToString("C", CultureInfo.CurrentCulture) + "\n" + alert);
        }
    }
}
