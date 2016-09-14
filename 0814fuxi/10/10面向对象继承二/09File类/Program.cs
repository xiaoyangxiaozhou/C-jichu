using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _09File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个文件
            //File.Create(@"C:\Users\hongmf\Desktop\test.txt");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //删除一个文件
            //File.Delete(@"C:\Users\hongmf\Desktop\test.txt");
            //Console.WriteLine("删除成功");
            //Console.ReadKey();

            //复制一个文件
            //File.Copy(@"C:\Users\hongmf\Desktop\test.txt", @"C:\Users\hongmf\Desktop\new.txt");
            //Console.WriteLine("复制成功");
            //Console.ReadKey();


            //byte[] buffer=File.ReadAllBytes(@"C:\Users\hongmf\Desktop\test.txt");//返回一个字节数组
            //将字节数组中的每一个元素都要按我们指定的编码格式解码成字符串
            //UTF-8   GB2312  GBK ASCII  Unicode(由UTF-7、UTF-8、UTF-32共同组成)
            //string s=Encoding.GetEncoding("GB2312").GetString(buffer);
            //string s = Encoding.Default.GetString(buffer);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //string str="今天天气好晴朗，处处好风光";
            ////需要将字符串转换成字节数组
            //byte[] buffer = Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\hongmf\Desktop\new.txt",buffer);
            //Console.WriteLine("写入成功");
            //Console.ReadKey();


           //string[] contents= File.ReadAllLines(@"C:\Users\hongmf\Desktop\test.txt", Encoding.Default);
           //foreach (string item in contents)
           //{
           //    Console.WriteLine(item);
           //}
           //Console.ReadKey();

            //string str=File.ReadAllText(@"C:\Users\hongmf\Desktop\test.txt", Encoding.Default);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //相对路径
            //string str = File.ReadAllText("test.txt", Encoding.Default);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //File.WriteAllLines(@"C:\Users\hongmf\Desktop\new.txt", new string[] {"aoe","euv" });
            //Console.WriteLine("OK");
            //Console.ReadKey();

            //File.WriteAllText(@"C:\Users\hongmf\Desktop\new.txt", "张三李四王五赵六");
            //Console.WriteLine("OK");
            //Console.ReadKey();

            //追加
            //File.AppendAllText(@"C:\Users\hongmf\Desktop\new.txt", "一二三四五");
            //Console.WriteLine("Ok");
            //Console.ReadKey();

        }
    }
}
