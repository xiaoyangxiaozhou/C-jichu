using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            //r.length = 4.5;
            //r.width = 3.5;
            r.Acceptdetails();
            r.Display();
            Console.ReadKey();
        }
    }
}
