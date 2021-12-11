using System;
using System.Collections.Generic;
using System.Text;

namespace Lection13
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
        }

        public override void SaySound()
        {
            Console.WriteLine($"Cat {Name} sound!");
        }
    }
}
