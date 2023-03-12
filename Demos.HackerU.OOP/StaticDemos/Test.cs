using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.StaticDemos
{
    public class Test
    {
        private readonly int test;//Non Static member
        public const int DATANUM = 100;//static by default
        public const string DATATEXT = "ABC";//static by default
        private static readonly int val; //can be initialized in static constructor
        public Test()
        {
            test = 1;
        }
        public Test(int test)
        {
            //read-only can be set in constructor
            this.test = Test.DATANUM + test;
        }

        /// <summary>
        /// trigger before any other constractor
        /// triggger once
        /// </summary>
        static Test()
        {
            val = -1; 
        }

    }
}
