using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11方法综合练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //用方法实现：用来判断用户输入的数字是不是质数，
            //再写一个方法，要求用户只能输入数字，输入有误就一直让用户输入
            //while (true)
            //{
            //    Console.WriteLine("请输入一个数字");
            //    string strnumber = Console.ReadLine();
            //    int number = GetNumber(strnumber);
            //    bool b = GetPrime(number);
            //    Console.WriteLine(b);
            //    Console.ReadKey();
            //}
            
        }

        /// <summary>
        /// 将输入的数字字符串转换为整数类型，若输入的不是数字，则提示重新输入
        /// </summary>
        /// <param name="s">输入的字符串</param>
        /// <returns>返回的转换为整数的数字</returns>
        public static int GetNumber(string s)
        { 
            while(true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("您输入的不是数字，请重新输入");
                    s = Console.ReadLine();
                }
            }
        }


        /// <summary>
        /// 判断输入的数是否为质数
        /// </summary>
        /// <param name="n">用户输入的数字</param>
        /// <returns>返回质数</returns>
        //public static bool GetPrime(int n)
        //{
        //    if (n < 2)
        //    {
        //        Console.WriteLine("输入的不是质数");
        //    }
        //    else
        //    {
        //        for (int i = 2; i < n; i++)
        //        {
        //            if (n % i == 0)
        //            {
        //                return false;
        //            }
               
        //        }
        //    }
            
        //    return true;

        //}
    }
}
