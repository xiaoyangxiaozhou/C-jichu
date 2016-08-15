using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01基础班第四天
{
    class Program
    {
        static void Main(string[] args)
        {
            //求1到100之间所有整数的和
            //int i = 1;
            //int sum = 0;
            //while(i<=100)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("1到100的总和为{0}",sum);
            //Console.ReadKey();

            //求1到100之间所有偶数的和
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }

            //    i++;
            //}
            //Console.WriteLine("1到100的偶数总和为{0}", sum);
            //Console.ReadKey();

            //求1到100之间所有奇数的和
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sum += i;
            //    }

            //    i++;
            //}
            //Console.WriteLine("1到100的奇数总和为{0}", sum);
            //Console.ReadKey();

            //int i = 1;
            //int j = 1;
            //while(i<=10)
            //{
            //    while (j <= 10)
            //    {
            //        Console.WriteLine("我是里面的{0}",j);
            //        j++;
            //    }
            //    Console.WriteLine("我是外面的");
            //    i++;
            //}
            //Console.ReadKey();

            //要求用户输入用户名和密码，用户名只要不是admin，密码不是88888
            //string userName = "";
            //string userPwd = "";
            //while (userName != "admin" || userPwd != "88888")
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    userPwd = Console.ReadLine();
            //    Console.WriteLine("输入错误，请重新输入");

            //}
            //Console.WriteLine("登录成功");
            //Console.ReadKey();

            //输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩

            //Console.WriteLine("请输入班级人数");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int i=1;
            //int score = 0;
            //int sum = 0;
            //while (i<=number)
            //{
            //    Console.WriteLine("请输入第{0}位学生的成绩",i);
            //    score = Convert.ToInt32(Console.ReadLine());
            //    sum += score;
            //    i++;
            //}
            //Console.WriteLine("学员的总成绩为{0},平均成绩为{1}",sum,sum/number);
            //Console.ReadKey();

            //老师问学生，这道题你会做了吗？如果学生回答“会了（y）”，则可以放学，如果学生不会做(n)，则老师再讲一遍，再问学生是否会做了，
            //直到学生会为，才可以放学； 2）直到学生或老师给他讲了10遍还不会，都要放学
            //string answer = "";
            //while (answer != "y")
            //{
            //    Console.WriteLine("老师问学生这道题会做了吗,y、n");
            //    answer = Console.ReadLine();
            //}
            //Console.WriteLine("大家都会做了，放学了");
            //Console.ReadKey();

            //string answer = "";
            //int i = 1;
            //while (answer != "y"&& i<=10)
            //{
            //    Console.WriteLine("老师问学生这道题会做了吗,y、n");
            //    answer = Console.ReadLine();
            //    i++;
            //}
            //Console.WriteLine("放学了");
            //Console.ReadKey();

            //2006年培养学员80000人，每年增长25%，请问按此速度，到哪一年培训学员人数将达到20万人
            //double number = 80000;
            //int i = 1;
            //while (number <= 200000)
            //{
            //    number = number * 1.25;
            //    i++;
            //}
            //Console.WriteLine("到{0}年学员达到20万人,人数是{1:0}", 2006 + i - 1, number);
            //Console.ReadKey();

           
            //明天小兰就要登台演出了，老师说再把明天的演出的歌曲唱一遍，
            //如果满意，小兰就可以回家了，否则就需要再练习一遍，直到老师满意为止
            //Console.WriteLine("明天的演出的歌曲唱一遍");
            //string answer = "";
            //while (answer != "yes")
            //{
            //    Console.WriteLine("老师，我的表演您满意吗");
            //    answer = Console.ReadLine();
            
            //}
            //Console.WriteLine("满意，你可以回家了");
            //Console.ReadKey();

            //string answer="";
            //do
            //{
            //    Console.WriteLine("老师，我的表演您满意吗");
            //    answer = Console.ReadLine();
            //} while (answer != "yes");
            //Console.WriteLine("满意，可以放学了");

            //Console.ReadKey();

            //不断要求用户输入学生姓名，输入Q 结束
                //string username="";
                //while(username!="Q")
                //{
                //    Console.WriteLine("请输入学生姓名");
                //    username=Console.ReadLine();

                //}
                //Console.ReadKey();
            //不断要求用户输入一个数字，然后打印这个数字的三倍，当用户输入的q的时候程序退出
            //string number = "";
            //while (number != "q")
            //{
            //    Console.WriteLine("请输入一个数字");
            //    number=Console.ReadLine();
            //    try
            //    {
            //        int n = Convert.ToInt32(number);
            //        Console.WriteLine(n * 2);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("您输入的不是数字");
            //    }
            //}
            //Console.ReadKey();

            //不断要求用户输入一个数字(假如用户输入的数字都是正整数)
            //当用户输入end的时候显示刚才输入的数字中的最大值
            string number="";
            int max = 0;
            while (number != "end")
            {
                Console.WriteLine("请输入一个数字,输入end我们将显示你输入的最大值");
                number = Console.ReadLine();
                if (number != "end")
                {
                    try
                    {
                        int n = Convert.ToInt32(number);
                        //让用户输入的每个都跟我的假定的最大值比较，只要比我假定的最大值还要大，就赋值给我当前的最大值
                        if (n > max)
                        {
                            max = n;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("您输入的不是数字");
                    }
                }
                    
                else
                {
                    Console.WriteLine(max);
                }

            }
            Console.ReadKey();


        }
    }
}
