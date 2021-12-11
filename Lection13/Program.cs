using MMOLibrary;
using System;
using System.Collections.Generic;

namespace Lection13
{
    class Program
    {
        static int Min(int[] array)
        {//
            int a = 10;
            int b = 5;
            return a + b;
        }

        static int MaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static void VirtualExample()
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Cat("Basya");
            animals[1] = new Dog();

            foreach (var animal in animals)
            {
                animal.SaySound();
            }
        }

        static void ExtensionsExample()
        {
            for (int i = -10; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t{i.Square()}");
            }
        }

        static void EnumsExample()
        {
            foreach (var w in Enum.GetValues(typeof(Weight)))
            {
                Console.WriteLine(w);
            }

            Weight weight = Weight.Tonn;
            switch (weight)
            {
                case Weight.Gram:
                case Weight.Kilogram:
                    break;
                case Weight.Tonn:
                    break;
            }
            Console.WriteLine((int)weight);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void GameDemo()
        {
            int warriorWinsCount = 0;
            for (int i = 0; i < 10_000_000; i++)
            {
                Unit[] units = new Unit[2];
                units[0] = new Warrior();
                units[1] = new Archer();
                int attacker = 0;
                int defender = 1;
                while (units[0].IsAlive && units[1].IsAlive)
                {
                    units[attacker].Attack(units[defender]);
                    Swap(ref attacker, ref defender);
                }

                warriorWinsCount += units[0].IsAlive ? 1 : 0;
            }

            Console.WriteLine($"War win count: {warriorWinsCount}");
        }

        static void Main(string[] args)
        {
            LinkedList<int> arr = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                arr.AddLast(i);
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
