using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04基础班第四天
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int number = 0;
            //Console.WriteLine("请输入一个数字");
            //try
            //{
            //    number = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(number * 2);
            //}
            //catch
            //{
            //    Console.WriteLine("输入的不是数字");
            //}
            
            //Console.ReadKey();

            //bool b = true;
            //int number = 0;
            //Console.WriteLine("请输入一个数字");
            //try
            //{
            //    number = Convert.ToInt32(Console.ReadLine());
                
                
            //}
            //catch
            //{
            //    Console.WriteLine("输入的不是数字");
            //    b = false;
            //}
            //if (b)
            //{
            //    Console.WriteLine(number * 2);
            //}
           

            //Console.ReadKey();
#endregion

            #region
            //bool b = true;
            //Console.WriteLine("请输入你的考评成绩");
            //string level = Console.ReadLine();
            //double salary = 5000;
            //if (level == "A")
            //{
            //    salary += 500;
            //}
            //else if (level == "B")
            //{
            //    salary += 200;
            //}
            //else if (level == "C")
            //{ 
            
            //}
            //else if (level == "D")
            //{
            //    salary -= 200;
            //}
            //else if (level == "E")
            //{
            //    salary += 500;
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //    b = false;
            //}
            //if (b)
            //{
            //    Console.WriteLine("现在工资是{0}", salary);
            //}
            
            //Console.ReadKey();


            //bool b = true;
            //Console.WriteLine("请输入你的考评成绩");
            //string level = Console.ReadLine();
            //double salary = 5000;
            //switch (level)
            //{ 
            //    case "A":salary+=500;
            //        break;
            //    case "B":salary += 200;
            //        break;
            //    case "C":
            //        break;
            //    case "D": salary -= 200;
            //        break;
            //    case "E": salary -= 500;
            //        break;
            //    default: Console.WriteLine("输入有误");
            //        b = false;
            //        break;
            //}
            //if (b)
            //{
            //    Console.WriteLine("现在工资是{0}", salary);
            //}

            //Console.ReadKey();


            #endregion

            //请用户输入年份，再输入月份，控制台打印出该月的天数（结合之前闰年来做）
            Console.WriteLine("请输入年份");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());

                try
                {

                    Console.WriteLine("请输入月份");
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month > 0 && month < 13)
                    {

                        int day = 0;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12: day = 31;
                                break;
                            case 2:
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default: day = 30;
                                break;
                        }

                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("您输入的月份月误");
                    }
                }
                catch
                {
                    Console.WriteLine("您输入的月份不正确");
                }

            }
            catch
            {
                Console.WriteLine("您输入的年份不正确");
            }

            Console.ReadKey();



        }
    }
}
