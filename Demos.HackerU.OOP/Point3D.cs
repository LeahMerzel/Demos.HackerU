using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP
{
    public class Point3D
    {
        //field Private
        private int x;

        
        public string XText
        {
            get
            {
                return $"X:{X}";
            }
            set 
            {
                bool isValid =  int.TryParse(value, out int val);
               // x = isValid ? val : 0;
                if (isValid)
                {
                    x = val;
                }
            }
        }


        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value >= 0)
                    x = value;
                else
                    x = 0;
            }
        }


        public int Y { get; set; }
        public int Z { get; set; }


        public string GetInfo()
        {
            return $"{X},{Y},{Z}";
        }



    }
}
