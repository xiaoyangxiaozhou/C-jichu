using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04复习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 0, 4 };
            List<int> b = a.ToList<int>();
            b.RemoveAt(3);
            int[] c=b.ToArray<int>();
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
			
            Console.ReadKey();
        }

       
    }
}
