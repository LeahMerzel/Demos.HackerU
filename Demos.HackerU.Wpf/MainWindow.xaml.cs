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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello WPF");
            // Title += "X";
           string txt1 =  txtBox1.Text;
           string txt2 = txtBox2.Text;

            bool isOk1 =  int.TryParse(txt1,out int val1);
            bool isOk2 =  int.TryParse(txt2, out int val2);
            if (isOk1 && isOk2)
            {
                MessageBox.Show($"RESULT IS:{val1 + val2}");
            }
            else
            {
                MessageBox.Show("Error Input");
            }




        }
    }
}
