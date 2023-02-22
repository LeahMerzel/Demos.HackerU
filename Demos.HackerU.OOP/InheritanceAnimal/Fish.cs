using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.InheritanceAnimal
{
    public class Fish : BaseAnimal
    {
        public Fish()
        {
            Name = "<Fish No Name>";
        }

        public Fish(string name) : base(name)
        {
        }

        public new void DoMove()
        {
            Console.WriteLine($"Fish {Name} Move...");
        }

        public void DoSwim()
        {
            Console.WriteLine($"Fish {Name} Swimming...");
        }
    }
}
