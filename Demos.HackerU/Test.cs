using System;
using System.Collections.Generic;
using System.Linq;

namespace Demos.HackerU.Testing
{

    internal class Test
    {
        public static void TestA()
        {
            Console.WriteLine("Demos.HackerU.Testing.Test.TestA() Invoked....");
        }

        public static void MethodA()
        {
            Console.WriteLine("MethodA Invoked...");
        }
        public static void MethodB()
        {
            //Run Using Full Name: Namspace.Class.Method
            System.Console.WriteLine("MethodB Invoked...");

        }


    }
}
