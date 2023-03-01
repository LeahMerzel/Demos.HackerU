using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Interfaces
{
    public interface ILogger
    {
        void Log(string text, int level);
        void Log(string text, int level,string fileName);
    }
}
