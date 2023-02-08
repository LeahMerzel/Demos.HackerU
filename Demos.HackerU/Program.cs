using System;
using System.Xml.Linq;
using Demos.HackerU.CommonTypes;
using Demos.HackerU.HomeWorks;
using Demos.HackerU.OOP;

namespace Demos.HackerU
{
    //Main Application Program (Gadi)
    internal class Program
    {
        static void Main(string[] args)
        {

            //StringsDemos.Run();

            //BasicTypesDemos.Run();

            //ArraysAndLoops.Run();

            //ConvertTypes.Run();
            //EnumsDemos.Run();

            //HW2.Run();

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

            Point p3 = new Point{X=5,Y=5};
            p3.Display();
            //Get
            int myX = p3.X;
            //Set
            p3.X = 0;

            p3.Y = 0;
            p3.AddX(5);
            p3.Display();





            //--WAIT FOR USER PRESS ANY KEY--
            Console.ReadKey();
        }


      
    }
}
