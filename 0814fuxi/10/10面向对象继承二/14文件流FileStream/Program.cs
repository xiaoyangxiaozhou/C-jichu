using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _14文件流FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream  操作字节，代表可以打操作任何文件 
            //使用FileStream来读取数据
            //1、创建FileStream对象
            //FileStream fsRead = new FileStream(@"C:\Users\hongmf\Desktop\test.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            ////返回本次实际读取到的有效字节数
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            ////将字节数组中每一个元素按照指定的编码格式解码成字符串
            //string s = Encoding.Default.GetString(buffer, 0, r);
            ////关闭流
            //fsRead.Close();
            ////释放流所占的资源
            //fsRead.Dispose();
            //Console.WriteLine(s);
            //Console.ReadKey();

            //使用FileStream来写入数据,用using释放流所占的资源
            //using (FileStream fsWrite = new FileStream(@"C:\Users\hongmf\Desktop\test.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    string str = "看我有没把你干掉";
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    fsWrite.Write(buffer,0,buffer.Length);

            //}
            //Console.WriteLine("写入OK");
            //Console.ReadKey();


            //StreamReader和StreamWriter  操作字符的，操作文本文件

        }
    }
}
