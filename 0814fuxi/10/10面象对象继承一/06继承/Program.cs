using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个Reporter类和一个Programmer类，Driver类，他们都有一个打招呼的方法，
            //不同的是Report打招呼是说“大家好，我的爱好是偷拍，我的年龄是34，我是一个男狗仔”，
            //Driver：我叫舒马赫，我的年龄是23，我是男人，我的驾龄是23年
            //Programmer打招呼的方法是说"大家好，我叫孙全，我的年龄是23，我是男生，我已经工作3年了"
            Reporter rep = new Reporter("狗仔",34,'男',"偷拍");
            rep.ReporterSayHello();

            Programmer pro = new Programmer("程序员", 23, '男', 3);
            pro.ProgrammerSayHello();

            Console.ReadKey();

        }
    }
}
