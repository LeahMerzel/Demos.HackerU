using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.CommonTypes
{
    public class BasicTypes
    {
        public static void Run()
        {
            TestNumerics();


        }

        private static void TestNumerics()
        {
            int x = 10;
            int y = 100;
            int z = x + y;
            Console.WriteLine($"x={x},y={y},z={z}");

            double d1 = 5.75;
            double d2 = 5.75345456;
            d1++;//d1 = d1+1;
            d1 += 6f;//d1 = d1+6
            d1 += d2;//d1 = d1+6
            Console.WriteLine($"d1={d1}");

            float f = 10.34f;
            Console.WriteLine($"f={f}");

            bool isEquals = (d1 == d2);
            Console.WriteLine($"isEquals d1=d2 ---> {isEquals}");









        }
    }
}
