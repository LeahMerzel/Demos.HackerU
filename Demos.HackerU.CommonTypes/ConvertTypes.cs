using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.CommonTypes
{
    public class ConvertTypes
    {   

        public static void TestOut(out int value )
        {
            //....

            value = 100;

        }



        public static void  Run()
        {

            int num =10;
            TestOut(out  num);
            Console.WriteLine(num);

            int num1;
            TestOut(out num1);
            Console.WriteLine(num1);



            string s1 = "12a";
            //  int num = int.Parse(s1);

            int number;
            bool isConvertedOk = int.TryParse(s1, out number);
            if (isConvertedOk)
            {
                number += 10;
            }
            else
            {
                Console.WriteLine(s1 + " is not number format");
            }


            bool b = false; 
            isConvertedOk =  bool.TryParse("false", out bool ConvertedBool);

            float f = 12.3f;
            double d1 =  Convert.ToDouble(f);

            //Casting
            object o1 = f;
            var d2 = (float)o1;

            //is operator c#
            if (o1 is float num2)
            {
                num2 += 10.3f;
            }

            // Read From User  float number between 0-1 
            // Print Percent
            //1) Read String 
            //2) float.tryParse
            //3) Calaculate Percent



        }



    }
}
