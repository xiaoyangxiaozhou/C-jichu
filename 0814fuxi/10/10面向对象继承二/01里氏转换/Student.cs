using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01里氏转换
{
    public class Student:Person
    {
        public void StudentSayHi()
        {
            Console.WriteLine("我是学生");
        }
    }
}
