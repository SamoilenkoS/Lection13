using System;
using System.Collections.Generic;
using System.Text;

namespace Lection13
{
    public abstract class Animal
    {
        private double _weight;
        protected bool _isAlive;
        public string Name { get; set; }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if(value > 0.1)
                {
                    _weight = value;
                }
            }
        }

        public Animal()
        {
            _weight = 1;
        }

        public virtual void SaySound()
        {
            Console.WriteLine("Animal sound!");
        }
    }
}
