using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Interfaces
{
    public interface IPoint
    {
        int XLoc { get; set; }
        int YLoc { get; set; }

        double Distance();

    }
}
