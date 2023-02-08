using Microsoft.VisualBasic;
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

namespace Demos.HackerU.Wpf
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

   

    

        private void TestClass_Click(object sender, RoutedEventArgs e)
        {
             Calculator calculator1 = new Calculator();
             calculator1.num1 = 10;
             calculator1.num2 = 20;
             float res1 = calculator1.Calculate(Operation.Plus);

            Calculator calculator2 = new Calculator();
            calculator2.num1 = 30;
            calculator2.num2 = 5;
            float res2 = calculator2.Calculate(Operation.Plus);

            Calculator calculator3 = new Calculator();
            calculator3.num1 = 30;
            calculator3.num2 = 5;
            float res3 = calculator3.Calculate(Operation.Plus);





        }
    }
}
