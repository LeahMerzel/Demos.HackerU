using System;
using System.Xml.Linq;
using Demos.HackerU.Testing;
using Demos.HackerU.CommonTypes;

namespace Demos.HackerU
{
    //Class
    internal class Program
    {
        static void Main(string[] args)
        {

            StringsDemos.Run();
          
           
            //--WAIT FOR USER PRESS ANY KEY--
            Console.ReadKey();
        }



        /// <summary>
        /// 
        /// </summary>
        //public static void NamespacesDemos()
        //{
        //    Console.WriteLine("Hello, World!");
        //    Console.WriteLine("Print Any Key to Exit");

        //    //--Call Method A 2 times
        //    //Use Full name
        //    Demos.HackerU.MyClass.MethodA();

        //    //Full Name Is not Required Because 
        //    //MyClass is in the same Namspace
        //    //as caller class (Program)
        //    //Program and MyClass are in the same namspace
        //    //So Full Name is Not Reuired
        //    MyClass.MethodA();

        //    //--Call Method B 
        //    MyClass.MethodB();

        //    //--Call Testing Full Name
        //    Demos.HackerU.Testing.Test.TestA();

        //    //--We put "using Demos.HackerU.Testing;" at the top file 
        //    //--So Full Name Is Not Required
        //    Test.TestA();

        //    Test.TestA();
        //    Test.MethodB();


        //    Console.ReadKey();
        //}





      
    }
}