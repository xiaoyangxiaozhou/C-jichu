using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.里氏转换
            //1）子类可以赋值给父类
            //string str = string.Join("1", new string[] { "1", "2", "3", "4" });
            //Console.WriteLine(str);
            //Console.ReadKey();
            //2）如果父类中装的是子类对象，那么可以将这个父类强转为子类对象。


            //关于里氏转换的练习：创建10个对象，通过一个循环，去调用他们各自打招呼的方法
            //Person[] pers=new Person[10];
            //Random r=new Random();
            //for (int i = 0; i < pers.Length; i++)
            //{
            //    int rNumber = r.Next(1,7);
            //    switch (rNumber)
            //    {
            //        case 1: pers[i]=new Student();
            //            break;
            //        case 2: pers[i] = new Teacher();
            //            break;
            //        case 3: pers[i] = new ShuaiGuo();
            //            break;
            //        case 4: pers[i] = new MeiLv();
            //            break;
            //        case 5: pers[i] = new YeShou();
            //            break;
            //        case 6: pers[i] = new Person();
            //            break;
            //    }
            //}
            //for (int i = 0; i < pers.Length; i++)
            //{
            //    if (pers[i] is Student)
            //    {
            //        ((Student)pers[i]).StudentSayHi();

            //    }
            //    else if (pers[i] is Teacher)
            //    {
            //        ((Teacher)pers[i]).TeacherSayHi();
            //    }
            //    else if (pers[i] is MeiLv)
            //    {
            //        ((MeiLv)pers[i]).MeiLvSayHi();
            //    }
            //    else if (pers[i] is ShuaiGuo)
            //    {
            //        ((ShuaiGuo)pers[i]).ShuaiGuoSayHi();
            //    }
            //    else if (pers[i] is YeShou)
            //    {
            //        ((YeShou)pers[i]).YeShouSayHi();
            //    }
            //    else
            //        pers[i].PersonSayHi();

            //}
            //Console.ReadKey();
        }
    }
}
