﻿using System;

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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
