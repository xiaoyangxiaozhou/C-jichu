using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05dayfuxi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //不断要求用户输入一个数字(假如用户输入的数字都是正整数)，当用户输入end的时候显示刚才输入的数字中的最大值
            //string input = "";
            //int max = 0;
            //while (input != "end")
            //{
            //    Console.WriteLine("请输入一个数字，当用户输入end时输出刚才的最大值");
            //    input = Console.ReadLine();
            //    if (input != "end")
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(input);
            //            if (number > max)
            //            {
            //                max = number;
            //            }
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入错误，不是数字");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("刚才数字中的最大值为{0}", max);
            //    }

            //}
            //Console.ReadKey();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("欢迎来到传智播客学习");
            //}
            //Console.ReadKey();

            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
            #endregion

           #region
            //求1-100之间的所有整数和  偶数和  奇数和
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //int sum = 0;
            //for (int i = 2; i <= 100; i+=2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //int sum = 0;
            //for (int i = 1; i <=100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //找出100-999之间的所有水仙花数
            //（水仙花数指的百位数字的百位的立方+十位的立方+个位的立方==百位数）
            //例如153：百位数153/100;十位数153%100/10;个位数:153%10
            //for (int i = 100; i <1000; i++)
            //{
            //    int n1=i/100;
            //    int n2=i%100/10;
            //    int n3=i%10;
            //    if(i==n1*n1*n1+n2*n2*n2+n3*n3*n3)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();
           #endregion

            #region
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
                    
            //        Console.Write("{0}*{1}={2} \t",i,j,i*j);
                    
            //    }
            //    Console.WriteLine();//换行
            //}
            //Console.ReadKey();

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //Console.WriteLine("请输入一个值");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("根据这个值可以出以下加法:");
            //for (int i = 0; i <=number; i++)
            //{
            //    for (int j = number; j >= 0; j--)
            //    {
            //        if (number == i + j)
            //        {
            //            Console.WriteLine("{0}+{1}={2}",i,j,number);
            //        }
            //    }
            //}
            //Console.ReadKey();
            #endregion



        }
    }
}
