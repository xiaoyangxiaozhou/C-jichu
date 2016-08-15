using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03基础班第三天
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            ////编程实现107653秒是几天几小时几分钟几钞？
            //int secs = 107653;
            //int day =secs/86400;
            //secs = secs % 86400;
            //int hour = secs / 3600;
            //secs = secs % 3600;
            //int mins = secs / 60;
            //secs = secs % 60;
            //Console.WriteLine("107653秒是{0}天{1}小时{2}分钟{3}秒", day, hour, mins, secs);
            //Console.ReadKey();


            //闰年满足以下两个条件之一：年份能被400整除；年份能被4整除但不能被100整除
            //让用户输入一个年份，如果是闰年，则输出true,否则返回false
            //Console.WriteLine("请输入年份：");
            //int year = Convert.ToInt32(Console.ReadLine());
            //////bool b = year % 400==0;
            ////bool b = (year%4==0)&&(year%100!=0);
            //bool b = (year % 400==0) ||(year%4==0&&year%100!=0);
            //Console.WriteLine(b);
            //Console.ReadKey();

            //Console.WriteLine("请输入你的年龄");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if(age>=18)
            //{
            //    Console.WriteLine("你已经成年了");
            //}
            //Console.ReadKey();

            //Console.WriteLine("请输入你的考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //if (score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //else
            //{
            //    Console.WriteLine("E");
            //}
            //Console.ReadKey();
            //用if else该方法代码有误，见下

            //Console.WriteLine("请输入你的考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    if (score >= 80)
            //    {
            //        Console.WriteLine("B");

            //    }
            //    else
            //    {
            //        if (score >= 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if (score >= 60)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {

            //                Console.WriteLine("E");
            //            }
            //        }
            //    }
            
            //}

            //Console.ReadKey();

            //一般不这样写，多条件嵌套
            //用if else if
            //Console.WriteLine("请输入你的考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //else
            //{
            //    Console.WriteLine("E");
            //}
            //Console.ReadKey();
            #endregion

            #region
            //比较三个数字的大小
            //Console.WriteLine("请输入第一个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("n1>n2>n3");
            //}
            //if (n1 > n3 && n3 > n2)
            //{
            //    Console.WriteLine("n1>n3>n2");
            //}
            //if (n2 > n1 && n1 > n3)
            //{
            //    Console.WriteLine("n2>n1>n3");
            //}
            //if (n2 > n3 && n3 > n1)
            //{
            //    Console.WriteLine("n2>n3>n1");
            //}
            //if(n3>n2&&n2>n1)
            //{
            //    Console.WriteLine("n3>n2>n1");
            //}
            //if (n3 > n1 && n1 > n2)
            //{
            //    Console.WriteLine("n3>n1>n2");
            //}
            //Console.ReadKey();

            
           //比较三个数字的大小,输出最大值
            //Console.WriteLine("请输入第一个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //if (n1 > n2)
            //{
            //    if (n1 > n3)
            //    {
            //        Console.WriteLine(n1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(n3);
            //    }
            //}
            //else
            //{
            //    if (n2 > n3)
            //    {
            //        Console.WriteLine(n2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(n3);
            //    }
            //}
            //Console.ReadKey();
#endregion



            //5. 提示用户输入用户名，然后再提示输入密码，
            //如果用户名是admin，密码是88888,则提示正确，
            //否则，如果用户名不是admin则提示用户名不存在，如果密码不是88888则提示密码错误。
            //Console.WriteLine("请输入用户名");
            //string username = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();
            //if (username == "admin"&&pwd=="88888")
            //{
            //    Console.WriteLine("正确");
            //}
            //else if (pwd == "88888")
            //{
            //    Console.WriteLine("用户名错误");
            //}
            //else if (username == "admin")
            //{
            //    Console.WriteLine("密码错误");
            //}
            //else
            //{
            //    Console.WriteLine("用户名密码均错误");
            //}
            //Console.ReadKey();

            
            
            
            
            //6.提示用户输入用户名，然后再提示输入密码，
            //如果用户名是admin，密码是88888,则提示正确，
            //否则提示用户再输入一次用户密码，如果正确，则提示正确，否则程序结束，退出
            //Console.WriteLine("请输入用户名");
            //string username = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();
            //if (username == "admin" && pwd == "88888")
            //{
            //    Console.WriteLine("正确");
            //}
            //else
            //{
            //    Console.WriteLine("输入错误，请重新输入用户密码");
            //    username = Console.ReadLine();
            //    pwd = Console.ReadLine();
            //    if (username == "admin" && pwd == "88888")
            //    {
            //        Console.WriteLine("正确");
            //    }
            //    else
            //    {
            //        Console.WriteLine("第二遍输入错误，退出");
            //    }
            //}
            //Console.ReadKey();

            //7.提示用户输入年龄，如果大于等于18，
            //则告知用户可以查看，如果小于10岁，则告知不允许查看，
            //如果大于等于10岁并且小于18岁，则提示用户是否继续查看，如果输入的yes则提示可以查看，否则提示退出，请放弃查看。
            //Console.WriteLine("请输入年龄");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("OK，可查看");
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("No,不允许查看");
            //}
            //else
            //{
            //    Console.WriteLine("请确认是否继续查看，yes/no");
            //    string input = Console.ReadLine();
            //    if (input == "yes")
            //    {
            //        Console.WriteLine("OK,查看吧");
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户放弃查看");
            //    }
            //}
            //Console.ReadKey();
        }
    }
}
