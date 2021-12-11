using System;
using System.Collections.Generic;
using System.Text;

namespace Lection13
{
    public static class ExtensionMethods
    {
        public static int Square(this int a)
        {
            return a * a;
        }
    }
}
