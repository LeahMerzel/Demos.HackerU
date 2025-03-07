﻿using Demos.HackerU.OOP.CarModels;
using Enums = Demos.HackerU.OOP.CarModels.Enums;
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
            this.Title = "Demos";
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

            Student s1 = new Student();
            s1.Name = "Moshe Ufnik"; 
            s1.Id = "34534564"; 
            s1.Grade = 50; 

            Student s2 = new Student();
            s2.Name = "David Yosec";
            s2.Id = "78784532";
            s2.Grade = 70;
            
            Student s3 = new Student();
            s3.Name = "Shlomo Hamelech";
            s3.Id = "34556767";
            s3.Grade = 100;

           string info1 =  s1.ShowStudent();
           bool isNotFail1 =  s1.IsFailed();
          
            string info2 = s2.ShowStudent();
            bool isNotFail2 =  s2.IsFailed();

            //Get
            string x = s3.Id;
            //Set
            s3.Id = "1111111";






        }

        /// <summary>
        /// Open Calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            CalculatorWindow winCalc = new CalculatorWindow("Calculator Demo");
            txtBoxLog.Text += "Open New Window\n";
            winCalc.ShowDialog();
            txtBoxLog.Text += winCalc.LastOperation + "\n";
            


        }

        private void btnStudentsWindow_Click(object sender, RoutedEventArgs e)
        {
            StudentWindow st = new StudentWindow();
            st.ShowDialog();
        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            Wheel w = new Wheel { Koter = 12.1f, Year = "2020" };
            Wheel w1 = new Wheel { Koter = 23.5f, Year = "2021" };
            Wheel w2 = new Wheel { Koter = 23.1f, Year = "2022" };
            Wheel w3 = new Wheel { Koter = 23.2f, Year = "2019" };

         

            Car c2 = new Car("000", "Toyota", Enums.Colors.White, 21);
            c2.AddWheel(w);
            c2.AddWheel(w1);
            c2.AddWheel(w2);
            c2.AddWheel(w3);
            c2.Eng = new Engine(600);


            Car c3 = new Car("12-345-67", "BMW", Enums.Colors.Black, 20);
            c3.AddWheel(new Wheel { Koter = 12.1f, Year = "2018" });
            c3.AddWheel(new Wheel { Koter = 12.1f, Year = "2016" });
            c3.AddWheel(new Wheel { Koter = 12.1f, Year = "2015" });
            c3.AddWheel(new Wheel { Koter = 12.1f, Year = "2014" });
            c3.Eng = new Engine(400);

            List<Car> l = new List<Car>() { c2, c3 };

            CarsWindow carwin = new CarsWindow(l,"Cars Demo");
            carwin.ShowDialog();
        }
    }
}
