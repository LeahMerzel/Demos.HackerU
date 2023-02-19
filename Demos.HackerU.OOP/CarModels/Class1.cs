using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.CarModels
{
    public class Validation
    {

        public static string ValidateSetIdNum(string idNum)
        {
            string defaultFormat = "00-000-00";
            if ( idNum.Contains("-") &&
                 idNum.Length < 10)
               {
                defaultFormat = idNum;
               };


            return defaultFormat;

        }
    }
}
