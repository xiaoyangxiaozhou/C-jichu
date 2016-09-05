using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01里氏转换
{
    public class Teacher:Person
    {
        public void TeacherSayHi()
        {
            Console.WriteLine("我是老师");
        }
    }
}
