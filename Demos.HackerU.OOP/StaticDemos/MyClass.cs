using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.StaticDemos
{
    public class MyClass
    {
        //-Shared/Access by all instances
        //-Access from non static members(properties/methods)
        //-belong to the class and not to specific object

        private static int counter = 0;
        public int MyProperty { get; set; } = 0;

        public MyClass()
        {
            counter++;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StaticMethodA()
        {
            //this.MyProperty is not accessed
            //Not Allowed to run any method/property/field which is not static

            //Only Static are accessible
            counter += 100;

        }

        public int CountObjects { get => counter; }
    

    }
}
