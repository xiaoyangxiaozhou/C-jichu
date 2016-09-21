using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04接口的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别什么时候用虚方法、抽象类、接口实现多态？
            //真的鸭子会游泳 木头鸭子不会游泳 橡皮鸭子会游泳
            ISwimming swim = new XPDuck(); //new ReadlDuck();
            swim.Swim();
            Console.ReadKey();

        }
    }
    public class ReadlDuck:ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("真的鸭子靠翅膀会游泳");
        }
    }

    public class MuDuck
    { 
        
    }

    public class XPDuck : ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("橡皮鸭子靠水流游泳");
        }
    }

    public interface ISwimming
    {
        void Swim();
    }
}
