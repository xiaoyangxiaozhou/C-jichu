using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01fangfa
{
   //public enum Gender
   //{
   //     男,
   //     女
     
   //}
   //public enum Sesons
   //{ 
   //    春,
   //    夏,
   //    秋,
   //    冬
   
   //}
   //public enum QQState
   //{ 
   //     OnLine=1,  //0
   //     OffLine, //1
   //     Leave,
   //     Busy,
   //     QMe
   
   
   //}


   //public struct Person
   //{
   //   public string _name;
   //   public int _age;
   //   public Gender _gengder;
   
   //}

   //public struct MyColor
   //{
   //    public int _red;
   //    public int _green;
   //    public int _blue;

   
   //}
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Gender zsGender = Gender.男;
            //Sesons today = Sesons.夏;
            
            //QQState state = QQState.OffLine;
            ////将枚举类型转换为int类型
            //int n = (int)state;
            ////将int类型转换为枚举类型
            //int n1 = 3;
            //QQState state1 = (QQState)n1;
            //Console.WriteLine(n);
            //Console.WriteLine(state1);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion

            #region
            //所有类型都能够转换成string类型
            //int n1 = 10;
            //double n1 = 3.14;
            //decimal n1=500m;
            //QQState n1 = QQState.OffLine;
            //string s = n1.ToString();
            //Console.WriteLine(s);
            //Console.ReadKey();
            #endregion

            //枚举练习
            #region
            //提示用户选择一个在线状态，我们接收，并将用户的输入转换成枚举类型
            //再次打印到控制台
            //Console.WriteLine("请选择您的QQ在线状态 1-OnLine 2-OffLine 3-Leave 4-Busy 5-QMe");
            //string input = Console.ReadLine();
            //switch (input)
            //{
            //    case "1": QQState s1 = (QQState)Enum.Parse(typeof(QQState),input);
            //        Console.WriteLine(s1);
            //        break;
            //    case "2": QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine(s2);
            //        break;
            //    case "3": QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine(s3);
            //        break;
            //    case "4": QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine(s4);
            //        break;
            //    case "5": QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine(s5);
            //        break;
            
            //}


            //Console.ReadKey();
            #endregion

            //Person zsPerson;
            //zsPerson._name = "张三";
            //zsPerson._age = 21;
            //zsPerson._gengder=Gender.女;

            //Person lsPerson;
            //lsPerson._name= "李四";
            //lsPerson._age = 18;
            //lsPerson._gengder=Gender.男;
            

            //定义一个结构叫MyColor，有三个成员，分别定义为int类型的red,green,blue,
            //声明一个MyColor类型的变量，并对其成员进行赋值，使MyColor可以表示成一个红色
            //MyColor mc;
            //mc._red = 255;
            //mc._blue = 0;
            //mc._green = 0;
            
            //定义一个结构叫Person,有三个成员，分别为姓名，性别，年龄  性别用枚举类型;
            //声明两个Person类型的变量，分别表示张三 男 18岁  小兰 女 16岁



        }
    }
}
