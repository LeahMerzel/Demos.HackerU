using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.Wpf
{
    public class Student
    {
       public string  Name;
       public string Id;
       public int Grade;

        public string ShowStudent()
        {
            string displayInfo = $"{Id}|{Name}-{Grade}";
            return displayInfo;
        }
        public  bool NotFail()
        {
            return (Grade > 55);
        }






    }
}
