using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demos.HackerU.OOP.CarModels;
using Demos.HackerU.OOP.CarModels.Enums;
using Inheritance = Demos.HackerU.OOP.Inheritance;

namespace Demos.HackerU.OOP
{
    public class OOPDemos
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
            p1TextInfo =  p2.GetInfo();
            Console.WriteLine(p1TextInfo);

            // Initilize Object - Way 3
            Point3D p4 = new Point3D(2,3,4);
            p4.GetInfo();
            p4.X = 10;

            Point3D p5 = new Point3D();
            p5.X = 10;
            p5.GetInfo();



            if (p1 != p2)//Have the Same 
            {
                Console.WriteLine("NoT Equals")
  ;         }
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

            Point sp3 = new Point(12,-4);
            sp3.Display();


            List<string> list =new List<String> { "", "" };
        }

        public static void RunCarDemo()
        {
            Wheel w = new Wheel { Koter = 12.5f, Year = "2020" };
            Wheel w1 = new Wheel { Koter = w.Koter, Year = w.Year };
            Wheel w2 = new Wheel { Koter = w.Koter, Year = w.Year };
            Wheel w3 = new Wheel { Koter = w.Koter, Year = w.Year };

            Car c1 = new Car();

            Car c2 = new Car("000", "China",Colors.White, 21);
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

            Inheritance.Point3D p1 = new Inheritance.Point3D(2,3,5);
            p1.Display();

            Inheritance.Point3D p2 = new Inheritance.Point3D(8);
            p2.Display();



            //Inheritance.Point3D p3 = new Inheritance.Point3D("2:3:5");
            //p3.Display();
        }

    }
}
