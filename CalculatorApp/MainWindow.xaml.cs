using System.Windows;
using System.Windows.Controls;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double lastNumber, result;
        string selectedOperator;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0") txtDisplay.Text = "";
            txtDisplay.Text += btn.Content.ToString();
        }
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            lastNumber = double.Parse(txtDisplay.Text);
            selectedOperator = ((Button)sender).Content.ToString();
            txtDisplay.Text = "0";
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double newNumber = double.Parse(txtDisplay.Text);

            if (selectedOperator == "+") result = lastNumber + newNumber;
            if (selectedOperator == "-") result = lastNumber - newNumber;
            if (selectedOperator == "*") result = lastNumber * newNumber;
            if (selectedOperator == "/") result = lastNumber / newNumber;

            txtDisplay.Text = result.ToString();
        }
    }
}