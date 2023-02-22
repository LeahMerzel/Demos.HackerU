using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Inheritance
{
    public class Point
    {
        int X { get; set; }
        int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point() : this(0, 0) { }

        /// <summary>
        /// Point p1 = new Point(5);
        /// </summary>
        /// <param name="val"></param>
        public Point(int val) : this(val, val)
        {
        }

        /// <summary>
        /// Put String in a format X:Y
        /// Example: 5:7
        /// </summary>
        /// <param name="xyPoint"></param>
        /// <example>new Point("2:3")</example>
        public Point(string xyPoint)
        {
            int xRes = 0;
            int yRes = 0;
            string[] xy = xyPoint.Split(":");
            if (xy.Length == 2)
            {
                //Parse x From Text
                string xText = xy[0];
                int.TryParse(xText, out xRes);

                //Parse y from Text
                string yText = xy[1];
                int.TryParse(yText, out yRes);
               
            }

            X = xRes;
            Y = yRes;
        }

        public void Display()
        {
            Console.WriteLine($"X:{X}Y:{Y}");
        }
















    }
}
