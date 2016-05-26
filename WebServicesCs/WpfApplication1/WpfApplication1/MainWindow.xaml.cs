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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            string helloString = client.HelloWorld();
            textBlock.Text = helloString;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double value1 = Convert.ToDouble(textBox.Text);
            double value2 = Convert.ToDouble(textBox1.Text);
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            double result = client.addNumbers(value1, value2);
            textBlock.Text = "Result: " + result;
        }

    }
}
