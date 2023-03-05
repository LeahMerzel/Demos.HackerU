using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.StaticDemos
{
    public class Entity
    {
        private static int _counter = 0;
        public int Id { get;  }

        public Entity()
        {
            _counter++;
            Id = _counter;
        }
    }
}
