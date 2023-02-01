using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.CommonTypes
{
    public class ArraysAndLoops
    {
        public static void Run()
        {
            ListIterations();
        }

        public static void ListIterations()
        {
            //--Object of type Array 
            List<int?> l = new List<int?>();
            l.Add(1);
            l.Add(10);
            var l2 = new List<int>() { 10,20,30 };
            int founditem = l2.Find(n => n >10);
            int foundindex= l2.FindIndex(n => n == 90);
            if (foundindex>0)
            {
                Console.WriteLine(foundindex);
            }
            //Foeach LOOP is iterating each value of the array
            foreach (int numItem in l2)
            {
                Console.WriteLine(numItem);
            }





        }





    }
}
