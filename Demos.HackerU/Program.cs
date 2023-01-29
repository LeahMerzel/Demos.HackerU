using System;
using System.Xml.Linq;
using Demos.HackerU.Testing;
using Lib1;

namespace Demos.HackerU
{
    //Class
    internal class Program
    {
        static void Main(string[] args)
        {

           
            //--01: NamespacesDemos and Classes
            //Program.NamespacesDemos();
            
            //--02: Strings 
            Program.Strings();

            ClassLib.FuncA();

            //--WAIT FOR USER PRESS ANY KEY--
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        private static void Strings()
        {
            //----------------------------------------------------
            //02 - Strings
            //----------------------------------------------------
            //CommonTypesStrings.TestString();
            //CommonTypesStrings.Lab1();
            //CommonTypesStrings.Lab2("abc","def");
            //-----------
            //string res = CommonTypesStrings.Lab3("ABC", "DEF");
            //Console.WriteLine(res);
            //-----------
            // bool isLoggedIn =  CommonTypesStrings.Lab4_Login("user123", "Pa$$w0rd");
            // Console.WriteLine($"is Logged In : {isLoggedIn}");
            //-----------------------------------------------------
            // bool isLoggedIn = CommonTypesStrings.Lab5_Login("user", "12345");
            // Console.WriteLine($"is Logged In : {isLoggedIn}");
            bool isEqual1 = CommonTypesStrings.CheckLowerUpperEquals("Abc", "aBC");
            Console.WriteLine($"Test 1:{isEqual1}");
            bool isEqual2 = CommonTypesStrings.CheckLowerUpperEquals(null,"abc");
            Console.WriteLine($"Test 2:{isEqual2}");
            bool isEqual3 = CommonTypesStrings.CheckLowerUpperEquals("", "");
            Console.WriteLine($"Test 3:{isEqual3}");


       //Create new Class lib Project name it HomeWorks
       // - Add new Class Name it Hw1
       // - Add the method CheckLowerUpperEquals
       // - Run It From Prgram Main




        }

        /// <summary>
        /// 
        /// </summary>
        public static void NamespacesDemos()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Print Any Key to Exit");

            //--Call Method A 2 times
            //Use Full name
            Demos.HackerU.MyClass.MethodA();

            //Full Name Is not Required Because 
            //MyClass is in the same Namspace
            //as caller class (Program)
            //Program and MyClass are in the same namspace
            //So Full Name is Not Reuired
            MyClass.MethodA();

            //--Call Method B 
            MyClass.MethodB();

            //--Call Testing Full Name
            Demos.HackerU.Testing.Test.TestA();

            //--We put "using Demos.HackerU.Testing;" at the top file 
            //--So Full Name Is Not Required
            Test.TestA();

            Test.TestA();
            Test.MethodB();


            Console.ReadKey();
        }





      
    }
}