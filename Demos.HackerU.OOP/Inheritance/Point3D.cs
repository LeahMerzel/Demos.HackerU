using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Inheritance
{
    public class Point3D : Point
    {

        public int Z { get; set; }

        public Point3D():base() 
        {
            Z = 0;
        }
        public Point3D(int x,int y,int z):base(x,y)
        {
            Z = z;
        }





        public new void Display()
        {
             base.Display();
             Console.Write($"Z:{Z}");
        }


    }
}
