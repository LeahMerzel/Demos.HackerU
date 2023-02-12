using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           //Object 1
            Point3D p1 = new Point3D();
            p1.X = 2;
            p1.Y = 10;
            p1.Z = 15;
            string p1TextInfo = p1.GetInfo();
            Console.WriteLine(p1TextInfo);


            //Object 2
            Point3D p2 = new Point3D { X = 2, Y = 10, Z = 15 };
            p1TextInfo =  p2.GetInfo();
            Console.WriteLine(p1TextInfo);

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
            p1.describeText = "כעראע";

        

        }


    }
}
