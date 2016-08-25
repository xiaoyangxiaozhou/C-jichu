using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05使用out参数做登陆
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别提示用户输入用户名和密码,写一个方法来判断用户输入的是否正确
            //返回给用户一个登陆结果，并且还要单独的返回给用户一个登陆信息
            //如果用户名错误，除了返回登录结果之外，还要返回一个”用户名错误“
            //Console.WriteLine("请输入用户名");
            //string usrname = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();
            //string s;
            //bool b;
            //IsLogin(usrname, pwd, out s,out b);
            //Console.WriteLine(b);
            //Console.WriteLine(s);
            //Console.ReadKey();


        }
        /// <summary>
        /// 用户输入用户名和密码
        /// </summary>
        /// <param name="usrname">输入用户名</param>
        /// <param name="pwd">输入密码</param>
        /// <param name="s1">用户名正确，密码错误</param>
        /// <param name="s2">用户名错误，密码正确</param>
        /// <param name="s3">用户名、密码均错误</param>
        /// <param name="s4">登录成功</param>
        //public static void IsLogin(string usrname, string pwd, out string s ,out bool b)
        //{

        //    if (usrname == "admin" && pwd == "88888")
        //    {
        //        s = "登录成功";
        //        b = true;
        //    }

        //    else if (usrname == "admin")
        //    {
        //        s = "登录失败，密码错误";
        //        b = false;

        //    }
        //    else if (pwd == "88888")
        //    {
        //        s = "登录失败，用户名错误";
        //        b = false;

        //    }
        //    else
        //    {
        //        s = "登录失败，用户名密码均错误";
        //        b = false;

        //    }
        //}

    }
}
