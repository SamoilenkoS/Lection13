using System;
using System.Collections.Generic;
using System.Text;

namespace Lection13
{
    public class Dog : Animal
    {
        public string Type { get; set; }
        public Dog()
        {
            _isAlive = true;
        }

        public override void SaySound()
        {
            Console.WriteLine("Dog sound!");
        }
    }
}
