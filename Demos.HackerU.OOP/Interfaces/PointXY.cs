using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Interfaces
{
    internal class PointXY : IPoint
    {
        public int _xPoint;
        //public int _yPoint;

        public PointXY(int x,int y)
        {
            _xPoint = x;
            // _yPoint = y;
            YLoc = y;
        }

        public int XLoc { get => _xPoint; set => _xPoint = value; }
        public int YLoc { get; set; }

        public double Distance()
        {
            return Math.Sqrt(_xPoint * _xPoint + YLoc * YLoc);
        }
    }
}
