using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.StaticDemos
{
    public class MyClass
    {
        private static int counter = 0;
        public int MyProperty { get; set; } = 0;

        public MyClass()
        {
            counter++;
        }

        public int CountObjects { get => counter; }
    

    }
}
