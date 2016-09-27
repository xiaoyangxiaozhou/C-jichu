using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _01MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = GetMD5("123");
            Console.WriteLine(s);
            Console.ReadKey();
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            //开始加密
            //需要将字符串转换成字节数组
            byte[] buffer=Encoding.Default.GetBytes(str);
            //返回一个加密好的字节数组
            byte[] MD5Buffer = md5.ComputeHash(buffer);
            //将字节数组转换成字符串
            //方法：
            //1.将字节数组中每个元素按照指定的编码格式解析成字符串
            //2.将字节数组中的每个元素ToString()
            //3.直接将数组ToString()
            //return Encoding.Default.GetString(MD5Buffer);
            string MD5Str="";
            for (int i = 0; i < MD5Buffer.Length; i++)
            {
                MD5Str += MD5Buffer[i].ToString("X");//加X转换为十六进制;参考TOstring()特殊用法 
            }
            return MD5Str;


        }
    }
}
