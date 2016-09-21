using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            fly.Fly();
            Console.ReadKey();
        }
    }

    public class Person:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人类在飞");
        }
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }
    }


    public interface IFlyable
    {
        void Fly();//接口中的成员包括方法不允许添加访问修饰符，默认就是public；不允许写方法体的函数

    }
}
