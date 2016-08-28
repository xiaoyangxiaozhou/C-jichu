using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01类的基本语法
{
    class Program
    {
  
        static void Main(string[] args)
        {
           // Person sunQuan;//声明了一个Person类型的变量，person是自定义类
            //创建Person类的对象
            Person suQuan = new Person();
            suQuan.Name = "孙全";
            suQuan.Age = -23;
            suQuan.Gengder = '中';
            suQuan.CHLSS();
            Console.ReadKey();
        }
    }
}
