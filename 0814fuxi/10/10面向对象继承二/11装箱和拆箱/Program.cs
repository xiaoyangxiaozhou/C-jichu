using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            object o = n;//装箱
            int nn = (int)o;//拆箱

        }
    }
}
