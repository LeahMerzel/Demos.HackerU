using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Singelton
{
    /// <summary>
    /// Singelton Pattern:
    ///  allowed to create only one instance of a class
    /// </summary>


    public class MyManager
    {

        public string MyProperty { get; set; }


        private static MyManager instanceObj = null;
        /// <summary>
        /// private constractor
        /// Can be access only from inside the class 
        /// not allowed from main: MyManager m = new MyManager();
        /// </summary>
        private MyManager()
        {
            //
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static MyManager CreateInstance()
        {
            if (instanceObj == null)
            {
                instanceObj = new MyManager();
            }
            return instanceObj;
        }





    }
}
