using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWorks
{
    public class HW6
    {
        public  static void Run()
        {
            List<string> Students = new List<string>()
           {
               "Dani Shovevani",
               "Pinokio HouShmi",
               "Simba King"
           };
            Course c1 = new Course(1,
                                   CategoryEnum.DotNet,
                                   "Full Stack DotNet",
                                   "Bla Bla..",
                                   Students);
            Console.WriteLine(c1.DisplayCourseInfo());
            

        }
    }
}
