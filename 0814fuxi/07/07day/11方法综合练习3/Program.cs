using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11方法综合练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            //接收输入后判断其等级并显示出来。
            //判断依据如下:等级(优 900-100;良80-89，中70-79，差60-69，不合格
            //while (true)
            //{
            //    Console.WriteLine("请输入成绩");
            //    string scole = Console.ReadLine();
            //    int grade = GetGrade(scole);
            //    string s = GetLevel(grade);
            //    Console.WriteLine(s);
            //}

            //Console.ReadKey();

        }
        /// <summary>
        /// 将输入的成绩字符串转换为整数
        /// </summary>
        /// <param name="scole">输入的字符串成绩</param>
        /// <returns>返回转换后的整数成绩</returns>
        public static int GetGrade(string scole)
        {
            while (true)
            {
                try
                {
                    int grade = Convert.ToInt32(scole);
                    return grade;
                }
                catch
                {
                    Console.WriteLine("输入错误 ，请重新输入");
                    scole = Console.ReadLine();
                }
            
            }
        }

        /// <summary>
        /// 判断成绩等级
        /// </summary>
        /// <param name="grade">输入的成绩</param>
        /// <returns>返回的成绩等级</returns>

        //public static string GetLevel(int grade)
        //{
        //    string s = "";
        //    switch (grade / 10)
        //    { 
        //        case 10:
        //        case 9: s="优";
        //            break;
        //        case 8: s="良";
        //            break;
        //        case 7: s="中";
        //            break;
        //        case 6: s="差";
        //            break;
        //        default: s= "不合格";
        //            break;
        //    }
        //    return s;
        //}

    }
}
