﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Demos.HackerU.OOP.AbstractShapes;
using Demos.HackerU.OOP.Accounts;
using Demos.HackerU.OOP.CarModels;
using Demos.HackerU.OOP.CarModels.Enums;
using Demos.HackerU.OOP.ExtentionMethod;
using Demos.HackerU.OOP.InheritanceAnimal;
using Demos.HackerU.OOP.Interfaces;
using Demos.HackerU.OOP.Polimorphism;
using Demos.HackerU.OOP.Singelton;
using Demos.HackerU.OOP.StaticDemos;
using Inheritance = Demos.HackerU.OOP.Inheritance;

namespace Demos.HackerU.OOP
{
    public static class OOPRunDemos
    {
        public static void Run()
        {
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;

            Point p2 = new Point();
            p2.X = 5;
            p2.Y = 5;

            p1.Display();
            p2.Display();

            p2.Reset();
            p1.AddX(5);

            p1.Display();
            p2.Display();

            Point p3 = new Point { X = 5, Y = 5 };
            p3.Display();
            //Get
            int myX = p3.X;
            //Set
            p3.X = 0;

            p3.Y = 0;
            p3.AddX(5);
            p3.Display();

            //Array Of Objects
            Point[] points = { p1, p2, p3 };

            foreach (Point pointObj in points)
            {
                pointObj.Display();
            }

            points[0].Reset();
            points[1].Reset();
            points[2].Reset();

            foreach (Point pointObj in points)
            {
                pointObj.Display();
            }

            Point[] points2 = { new Point{X=0,Y=1 },
                                new Point { X = 10, Y = 10 } };
            points2[0].AddX(5);
            points2[0].AddY(5);
            foreach (Point pointObj in points2)
            {
                pointObj.Display();
            }

        }

        public static void PropsDemo()
        {
            //Initilize Object - Way 1
            Point3D p1 = new Point3D();
            p1.X = 2;
            p1.Y = 10;
            p1.Z = 15;
            string p1TextInfo = p1.GetInfo();
            Console.WriteLine(p1TextInfo);


            // Initilize Object - Way 2
            Point3D p2 = new Point3D() { X = 2, Y = 4, Z = 9 };
            p1TextInfo = p2.GetInfo();
            Console.WriteLine(p1TextInfo);

            // Initilize Object - Way 3
            Point3D p4 = new Point3D(2, 3, 4);
            p4.GetInfo();
            p4.X = 10;

            Point3D p5 = new Point3D();
            p5.X = 10;
            p5.GetInfo();



            if (p1 != p2)//Have the Same 
            {
                Console.WriteLine("NoT Equals")
  ;
            }
            if (p1.X == p2.X)
            {
                Console.WriteLine(" X Part is Equal");
            }

            //GET/SET + private member
            //Validation
            int x = p1.X;
            p1.X = 2;
            p1.SetX(5);
            p1.X = -5;


            Debug.WriteLine(p1.XText);

            p1.XText = "12a";
            p1.XText = "13";
            Debug.WriteLine(p1.XText);
            // p1.describeText = "כעראע";

            //Pulic that calls inner private methods 
            Console.WriteLine(p2.GetInfo());


            Point3D p3 = p1;
            if (p1 == p3)
            {
                Console.WriteLine("p1 AND p3 are Equls");

            }

            p1.X = 10;
            Console.WriteLine(p3.X);

            p3.X = 2;
            Console.WriteLine(p1.X);


            Point sp1 = new Point();
            sp1.Display();

            Point sp2 = new Point(5);
            sp2.Display();

            Point sp3 = new Point(12, -4);
            sp3.Display();


            List<string> list = new List<String> { "", "" };
        }

        public static void RunCarDemo()
        {
            Wheel w = new Wheel { Koter = 12.5f, Year = "2020" };
            Wheel w1 = new Wheel { Koter = w.Koter, Year = w.Year };
            Wheel w2 = new Wheel { Koter = w.Koter, Year = w.Year };
            Wheel w3 = new Wheel { Koter = w.Koter, Year = w.Year };

            Car c1 = new Car();

            Car c2 = new Car("000", "China", Colors.White, 21);
            c2.AddWheel(w);
            c2.AddWheel(w1);
            c2.AddWheel(w2);
            c2.AddWheel(w3);
            c2.Eng = new Engine(600);
            c2.DisplayToConsole();
            c2.SaveToFile("car.txt");


        }

        public static void RunInheritanceDemo()
        {
            // Inheritance.Point3D p1 = new Inheritance.Point3D();

            Inheritance.Point3D p1 = new Inheritance.Point3D(2, 3, 5);
            p1.Display();

            Console.WriteLine();


            Inheritance.Point3D p2 = new Inheritance.Point3D();
            p2.Display();

            Console.WriteLine();

            Inheritance.Point3D p3 = new Inheritance.Point3D("2:3:5");
            p3.Display();

            Console.WriteLine();



        }

        public static void RunAnimalDemo()
        {
            Fish f1 = new Fish("Nemo");
            f1.DoMove();
            f1.DoEat();
            f1.DoSwim();


            Bird b1 = new Bird("BigBird");
            b1.DoEat();
            b1.DoMove();
            b1.DoFly();

            List<BaseAnimal> animalsList = new List<BaseAnimal> { f1, b1 };
            foreach (BaseAnimal animalObj in animalsList)
            {
                animalObj.DoMove();//Move Animal
                animalObj.DoEat();

                //if (animalObj is  Bird)
                //{
                //    ((Bird)animalObj).DoFly();
                //}

                if (animalObj is Fish fish)
                {
                    fish.DoSwim();
                    fish.DoMove();//Move Fish
                }

                if (animalObj is Bird b)
                {
                    b.DoFly();
                    b.DoMove();
                }


            }



        }

        public static void RunPolimorphismDemo()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new QA(10));
            employees.Add(new QA(4));
            employees.Add(new Developer(1));
            //employees.Add(new Employee());
            employees.Add(new Manager(2));

            int sum = 0;
            foreach (Employee employeeObj in employees)
            {
                sum += employeeObj.CalculateSalary();//POLIMORPHIC BEHAVIOR ON VIRTUAL-OVERRIDE
                Console.Write(employeeObj.GetType().Name);
                Console.Write(employeeObj.CalculateSalary());
                employeeObj.DisplayInfo();//POLIMORPHIC BEHAVIOR ON ABSTRACT-OVERRIDE
                Console.WriteLine();
            }

            Console.WriteLine("----------------------");
            Console.WriteLine(sum);

            //--Polimorphism (Tostring of QA Not Object due to Polimorphism)
            QA q1 = new QA(10);
            Console.WriteLine(q1);//


            ManagerAccount c1 = new ManagerAccount("MR Cohen", 23234, 10000, "BEZEQ");
            ManagerAccount c2 = new ManagerAccount("MR Levi", 567567, 3000, "HOT");
            List<Account> accounts = new List<Account>()
            {
                c1,c2
            };

            accounts[0].Deposit(1000);
            accounts[1].Withdraw(550);
            Account foundAccount = accounts.Find(a => a.AccountNum == 567567);
            if (foundAccount != null)
            {
                double balance = foundAccount.Withdraw(100);
            }

            //SIMPLE WAY
            Account c3 = new ManagerAccount("MR MOSHE", 1111, 10000, "BEZEQ");
            double currentBalance = c3.Withdraw(100);//Polimorphic behavior on absract-override


        }

        public static void ShapesDemo()
        {
            //--Polimorpism
            Shape s1 = new Circle(10, ShapeColor.White);
            Shape s2 = new Rectangle(10, 15, ShapeColor.White);
            Shape[] shapes = new Shape[] { s1, s2 };
            Shape s = shapes[0];
            //--Run Derived(Child) method from Base(Parent) Class 
            double resArea = s.CalculateArea();
            double resPerimeter = s.CalculatePerimeter();
            var areaRectangle = s2.Area;
            var perimeterRectangle = s2.Perimeter;

            var areaOfCircle = s1.Area;
            Console.WriteLine(s1);

            ILogger recLogger = new Rectangle(10, 8, ShapeColor.Red);
            recLogger.Log("Instance Rectangle Created", 0, "rect.txt");

            ManagerInfo(recLogger);
            ManagerInfo(new Rectangle(5, 12, ShapeColor.White));


            //Use Interface 
            IPoint p = new PointXY(2, 3);
            PrintPoint(p);



        }


        public static void ManagerInfo(ILogger logger)
        {
            //...
            logger.Log("log Demo", 5);
        }

        static void PrintPoint(IPoint p)//Any Class the Implement IPoint
        {
            Console.WriteLine("x={0}, y={1}", p.XLoc, p.YLoc);
        }


        public static void StaticDemo()
        {
            MyClass m1 = new MyClass();
            m1.MyProperty += 10;

            MyClass m2 = new MyClass();
            m2.MyProperty += 100;


            for (int i = 0; i < 100; i++)
            {
                MyClass m = new MyClass();
                m.MyProperty = i;
            }

            int x = m2.CountObjects;//102

            MyClass.StaticMethodA();

            //MyClass m3 = new MyClass();
            //m3.StaticMethodA()//Not Allowed


            //----------------------------------
            //Counter Demo
            ModelClass mc1 = new ModelClass();
            ModelClass mc2 = new ModelClass();
            ModelClass mc3 = new ModelClass();

            //Singelton Pattern
            // MyManager m = new MyManager(); //Not Allowed
            MyManager manager1 = MyManager.GetInstance();
            manager1.MyProperty = "ABCD";

            MyManager manager2 = MyManager.GetInstance();
            Console.WriteLine(manager2.MyProperty);

            // MyManager.CreateInstance().MyProperty = "XXX";

            //class work
            FileLogger.GetInstance("test.txt").Log("Test 123");
            FileLogger.GetInstance("test.txt").Log("Test 124");


        }


        public static void TestProtectedDemo()
        {
            //In Protected Folder (Namspace)
            Protected.Point3D p3d = new Protected.Point3D();
            //Not Allowed
            // p3d.ID = "XXX";
            Console.WriteLine(p3d.ID + ":");
            Console.WriteLine(p3d.GetInfoShort());

            p3d._testFieldC = "CCC"; //public
            //p3d._testFieldA = "AAA"; //Not Allowed
            //p3d._testFieldB = "BBB"; //Not Allowed 

            Protected.Point p1 = new Protected.Point();
            p1.AddX(10);
            p1._testFieldX = "XXXX"; //Internal 
        }

        /// <summary>
        /// Extension Method
        /// </summary>
        public static void TestExtensionDemo()
        {
            ExtentionMethod.DemoClassA dA = new ExtentionMethod.DemoClassA();
            dA.MethodA();
            dA.MethodB();
            dA.MethodC("XXXX");

            ILogger a = new LoggerA();
            a.LogWithTime("TEST", 5);

            string s = "ABC?DEF.GHI.123 456";
            int x =  s.WordCount();//5


        }

        //--Extension Method
        public static void MethodB(this ExtentionMethod.DemoClassA obj)
        {
            Console.WriteLine("MethodB");
            obj.MethodA();
           
        }

        //--Extension Method
        public static void MethodC(this ExtentionMethod.DemoClassA obj,string data)
        {
            Console.WriteLine("MethodB");
            obj.MethodA();
        }


        public static void Sort()
        {
            var p1 = new Sorting.Point { Id = 1, Title = "P1", X = 1, Y = 3 };
            var p2 = new Sorting.Point { Id = 2, Title = "P2", X = 5, Y = 6 };
            var p3 = new Sorting.Point { Id = 3, Title = "P3", X = 2, Y = 3 };
            var p4 = new Sorting.Point { Id = 4, Title = "P4", X = 4, Y = 7 };
            var p5 = new Sorting.Point { Id = 5, Title = "P5", X = 7, Y =8 };

            List<Sorting.Point> points = new List<Sorting.Point>();
            points.Add(p4);
            points.Add(p2);
            points.Add(p1);
            points.Add(p5);
            points.Add(p3);

            //Before Sort
            points.ForEach(p => Console.WriteLine(p.Id + ":" + p.Title));
          
            points.Sort();
            
            //After Sort
            points.ForEach(p => Console.WriteLine(p.Id + ":" + p.Title));





        }


    }
}