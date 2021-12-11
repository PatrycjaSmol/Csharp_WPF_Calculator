using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CurrentOperationText.Text = string.Empty;
            ResultText.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = string.Empty;
            var button = sender as Button;

            CurrentOperationText.Text += button.Name[button.Name.Length - 1];
            

        }

        private bool ContainsOperation(string operation) => operation.Contains("+") || operation.Contains("-") || operation.Contains("*") || operation.Contains("/");

        private void ButtonAadd_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
               CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += "+";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "-";
        }

        private void ButtonMultiple_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "*";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "/";
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {           
            var operation = CurrentOperationText.Text;

            ResultText.Text = CalculateResult(operation).ToString();

            CurrentOperationText.Text = string.Empty;
        }
        
        private int CalculateResult(string operation)
        {
            if (operation.Contains("+"))
            {
                var element = operation.Split('+');
                return int.Parse(element[0]) + int.Parse(element[1]);              
            }

            if (operation.Contains("-"))
            {
                var element = operation.Split('-');
                return int.Parse(element[0]) - int.Parse(element[1]);               
            }

            if (operation.Contains("*"))
            {
                var element = operation.Split('*');
                return int.Parse(element[0]) * int.Parse(element[1]);               
            }

            if (operation.Contains("/"))
            {
                var element = operation.Split('/');
                return int.Parse(element[0]) / int.Parse(element[1]);               
            }

            return default;

        }
    }
}
