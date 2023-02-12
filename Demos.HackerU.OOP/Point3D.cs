using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP
{
    public class Point3D
    {
        //field Private
        private int x;
        public int text;

        /// <summary>
        /// Empty Constractor
        /// Default Constractor
        /// </summary>
        public Point3D()
        {
            X = 0; Y = 0; Z = 0;
        }

        /// <summary>
        /// -Initialize all Fields
        /// -Initilize all Props
        /// -Call Other methods
        /// </summary>
        /// <param name="px"></param>
        /// <param name="py"></param>
        /// <param name="pz"></param>
        public Point3D(int X, int Y, int Z)
        {
            
            this.X = X;//Set Validation inside Property
            this.Y = Y;
            this.Z = Z;
        }

        public void SetX(int value)
        {
            //Call Other Private Method()
            x = value;
        }


      /// <summary>
      /// Wrapper for private x
      /// </summary>
        public string XText
        {
            get
            {
              
                return $"X:{x}";
            }
            set 
            {
                //--Validation for input value
                //--before set inner field x

                bool isValid =  int.TryParse(value, out int val);
               // x = isValid ? val : 0;
                if (isValid)
                {
                    x = val;
                }
            }
        }

        /// <summary>
        /// Full Property 
        /// for x 
        /// </summary>
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

        /// <summary>
        /// Auto Property
        /// </summary>
        public int Y { get; set; }
        public int Z { get; set; }

        /// <summary>
        /// member method can always access any inner private member
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
           string displayInfo =  GetInfoShort();
            //member method can always access any inner private member
            //x is private and still can be accessed
            //why: in the same class
            if (x >= 0 && x <= 9 &&
                Y >= 0 && Y <= 9 &&
                Z >= 0 && Z <= 9) 

            {
                displayInfo =   GetInfoFull();
            }

            return displayInfo;
        }

        /// <summary>
        /// Inner Private Member mehod
        /// inner Helper method
        /// Private : Cant accessed from
        /// outside the class 
        /// </summary>
        /// <returns></returns>
        private string GetInfoFull()
        {
            return $"[X:{x},Y:{Y},Z:{Z}]";
        }

        private string GetInfoShort()
        {
            return $"{x},{Y},{Z}";
        }





    }
}
