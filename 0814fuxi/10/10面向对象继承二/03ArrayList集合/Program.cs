using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _03ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了一个集合对象
            ArrayList list = new ArrayList();
            //集合：很多数据的一个集合
            //数组：长度不可度、类型单一
            //集合的好处：长度可以任意改变，类型随便
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
        }
    }
}
