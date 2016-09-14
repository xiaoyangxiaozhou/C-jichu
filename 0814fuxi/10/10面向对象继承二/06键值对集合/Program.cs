using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _06键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ////创建了一个键值对集合对象
            //Hashtable ht = new Hashtable();
            //ht.Add(1, "张三");
            //ht.Add(2, "李四");
            //ht.Add(3, true);
            //ht.Add(false, "错误的");
            //ht[6] = "新来的";
            //ht[5] = '男';
            //ht[1] = "把张三干掉";
            //ht.Clear();//移除集合中所有的元素
            //ht.Remove(3);

            //foreach (var item in ht.Keys)//在键里找每一个键值
            //{
            //    Console.WriteLine(ht[item]);
            //}

            ////在键值对集合中，是根据键去找值的
            //Console.WriteLine(ht[1]);
            //Console.WriteLine(ht[2]);
            //Console.WriteLine(ht[3]);
            //Console.WriteLine(ht[false]);
            //Console.WriteLine("===========================");
            //for (int i = 0; i < ht.Count; i++)  //for不能除数组外的键值
            //{
            //    Console.WriteLine(ht[i]);
            //}
            Console.ReadKey();
        }
    }
}
