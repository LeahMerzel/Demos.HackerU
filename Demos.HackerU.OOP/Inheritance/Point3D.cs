using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Inheritance
{
    //1)
    //--Use base
    //Implement consructor  3DPoint(3)
    //3DPoint(int xyz)

    //2)
    //--Use base
    //Implement constructor 3DPoint("3:5:8")



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


        public Point3D(int value):base(value)
        {
             Z = value;
            //X = value;
            //Y = value;
            //Z = value;
        }

        /// <summary>
        /// 2:3:4
        /// </summary>
        /// <param name="xyz"></param>
        public Point3D(string xyz):base(xyz)
        {
            int zRes = 0;
          
            string[] xyzArr = xyz.Split(":");
            if (xyz.Length >= 3)
            {
                //Parse x From Text
                string zText = xyzArr[2];
                int.TryParse(zText, out zRes);     
            }

            Z = zRes;
        }





        public new void Display()
        {
            //--Call Parent Methods ant props
             //base.Display();
             Console.Write($"{X},{Y},{Z}");
        }


    }
}
