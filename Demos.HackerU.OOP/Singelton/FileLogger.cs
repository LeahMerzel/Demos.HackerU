using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Singelton
{
    /// <summary>
    /// Make it Singelton
    /// 1) Make  Private constructor
    /// 2) create static member of this class
    /// 3) create GetInstance() Method and check run constructor once
    /// 
    /// </summary>
    public class FileLogger
    {
        private static FileLogger instanceObj = null;

        private string path;

        public void Log(string text)
        {
            File.AppendAllText(path, text + "\n");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        private FileLogger(string path)
        {
            this.path = path; 
        }

        public static FileLogger GetInstance(string path)
        {
            if (instanceObj == null)
            {
                instanceObj = new FileLogger(path);
                //instanceObj.path = path;
            }
            return instanceObj;
        }

    }
}
