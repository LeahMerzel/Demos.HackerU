
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
using System.Windows.Shapes;
using Demos.HackerU.OOP.CarModels;

namespace Demos.HackerU.Wpf
{
    /// <summary>
    /// Interaction logic for CarsWindow.xaml
    /// </summary>
    public partial class CarsWindow : Window
    {
         List<Car> ListCars { get; set; }
        public CarsWindow(List<Car> list,string title )
        {
            this.ListCars = list;
            this.Title = title;
            InitializeComponent();
           
        }

        public CarsWindow():this(new List<Car>(),"CarsWindowDemo")
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //PRINT TO LISTBOX ALL Car List
            lstBoxCars.ItemsSource = ListCars;
        }



    }
}
