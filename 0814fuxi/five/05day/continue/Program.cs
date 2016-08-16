using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("hello world");
            //    //break;
            //    continue;
            //    Console.WriteLine("hello world");//continue后面的代码不再继续
            //    Console.WriteLine("hello world");
            //}
            //Console.ReadKey();

            //用while continue实现计算1到100（含）之间的除了能被7整除之外的所有整数和。
            //int sum = 0;
            //for (int i = 1; i <=100; i++)
            //{
            //    if (i % 7 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("除被7整除外所有的整数和为{0}",sum);
            //Console.ReadKey();

            //int sum = 0;
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 7 == 0)
            //    {
            //        i++;
            //        continue;

            //    }
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //找出100内所有的质数(只能1和本身整除的数字，除1以外，最小的质数是2)
            
            //for (int i = 2; i <=100; i++)
            //{
            //    bool b = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        //除尽了说明不是质数，没有再往下的必要
            //        if (i % j == 0)
            //        {
            //            b = false;
            //            break;
            //        }
                    
            //    }
            //    if (b)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();

            //计算两个数字的大小，求出最大的的
            //Console.WriteLine("请输入第一个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int max=n1>n2?n1:n2;
            //Console.WriteLine(max);
            //Console.ReadKey();

            // 产生随机数
            // 创建能够产生随机数的对象
            // Random r = new Random();
            //while (true)
            //{
           
            //    //让产生随机数的这个对象调用方法来产生随机数
            //    int rNumber = r.Next(1, 10);
            //    Console.WriteLine(rNumber);
            //    Console.ReadKey();
            //}

            //输入名字随机显示这个人上辈子是什么样的人
            Random r = new Random();
            int rNumber = r.Next(1,7);
            Console.WriteLine("请输入一个姓名");
            string name = Console.ReadLine();
            switch (rNumber)
            {
                case 1: Console.WriteLine("{0}上辈子是王",name);
                    break;
                case 2: Console.WriteLine("{0}上辈子是赵", name);
                    break;
                case 3: Console.WriteLine("{0}上辈子是钱", name);
                    break;
                case 4: Console.WriteLine("{0}上辈子是孙", name);
                    break;
                case 5: Console.WriteLine("{0}上辈子是李", name);
                    break;
                case 6: Console.WriteLine("{0}上辈子是袁", name);
                    break;
                
            }
            Console.ReadKey();



        }
    }
}
