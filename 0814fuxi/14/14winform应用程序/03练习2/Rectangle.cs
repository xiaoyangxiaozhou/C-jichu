using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03练习2
{
    class Rectangle
    {
        double length;
        double width;


        public void Acceptdetails()
        {
            Console.WriteLine("请输入长度:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入宽度:");
            width = Convert.ToDouble(Console.ReadLine());
        }

        private double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("长度：{0}",length);
            Console.WriteLine("宽度：{0}",width);
            Console.WriteLine("面积：{0}",GetArea());
        }
    }
}
