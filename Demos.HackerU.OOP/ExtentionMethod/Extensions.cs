using Demos.HackerU.OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.ExtentionMethod
{
    public static class Extensions
    {
        /// <summary>
        /// Extension for string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                                StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void LogWithTime(this ILogger logger,string data,int level)
        {
            logger.Log(DateTime.Now.ToString()+ data,level);
        }


    }
}
