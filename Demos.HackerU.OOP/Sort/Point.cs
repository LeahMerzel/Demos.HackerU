using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Sorting
{
    public class Point : IComparable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(object obj)
        {
            //>0 Bigger
            //==0 Equal
            //< 0 Smaller
            if (obj is Point otherPoint)
            {
                if (X+Y == otherPoint.X+ otherPoint.Y)
                    return 0;
                else if (X + Y > otherPoint.X + otherPoint.Y)
                    return 1;
                else if (X + Y < otherPoint.X + otherPoint.Y)
                    return -1;

            }
            return 1;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }






    }
