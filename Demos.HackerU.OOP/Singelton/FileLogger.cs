using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Singelton
{
    /// <summary>
    /// Make it Singelton
    /// </summary>
    public  class FileLogger
    {
        public void Log(string text,string path)
        {
            File.WriteAllText(text,path);
        }


    }
}
