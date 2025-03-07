﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.CommonTypes
{
    /// <summary>
    /// List of pairs
    /// each item Key:Value
    /// ID UNIQE
    /// GET VALUE BY KEY is Very Quick O(1)  
    /// </summary>
    public class DictionaryDemos
    {

        //1) Create Point Class
        //            - X
        //            - Y
        //2)Create Dictionary<string,Point>
        //3) Add Items
        //Do Foreach In Order to Print All Points


        // Dictionary<string, Point> mapPoints = new Dictionary<string, Point>();
        //  Point p1 = new Point(1,2);
        // mapPoints.Add(p1.X+":"+p1.Y, p1);




        /// <summary>
        /// - Each key is Unique
        /// - Not Index Based
        /// - Save Pairs
        /// </summary>
        public static void Run()
        {
            var d1 = new Dictionary<string, string>();
            d1.Add("1", "One");
            d1.Add("2", "Two");



            //  d1.Add("2", "XXXXXX");

            string val = d1["1"];//One
            bool isExsist = d1.TryGetValue("2", out string valData);

            if (isExsist)
            {
                Console.WriteLine(valData);
            }
            else
            {
                Console.WriteLine("Not Exsist");
            }

            if (d1.ContainsKey("1"))
            {
                Console.WriteLine(d1["1"]);
            }

            Console.WriteLine("------------------");
            int counter = 0;

            if (d1["1"] == d1["2"])
            {

            }


            foreach (var item in d1)
            {

                Console.WriteLine($"{counter}:{item.Key},{item.Value}");
                counter++;

            }





        }


        /// <summary>
        /// Create Dictionary of Points
        /// </summary>
        public static void RunClassDemo()
        {
            //Dictionary<string, Point> mapPoints = new Dictionary<string, Point>();
            //Point p1 = new Point(1, 2);
            //mapPoints.Add("x", p1);
            //mapPoints.Add("y", p1);
            //mapPoints.Add(p1.X + ":" + p1.Y, p1);


            //foreach (var item in mapPoints)
            //{
            //    Console.WriteLine(item);

            //}

            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
            students.Add("23453245", new List<int> { 100, 99, 93, 97, 100 });
            students.Add("4544564", new List<int> { 100, 99, 93, 97, 100 });
            
            students["23453245"].Add(100);
            students["23453245"].RemoveAll(a => a == 100);
            List<int> values =  students["23453245"];


        }







    }
}
