using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _05字符串方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"--"cba"
            //Console.WriteLine("请输入字符串");
            //string input = Console.ReadLine();
            //char[] chs = input.ToCharArray();
            //Array.Reverse(chs);
            //input = new string(chs);
            //Console.WriteLine(input);
            //Console.ReadKey();
            
            //练习一，老师的方法一，方法二见以上，
            //string str = "abcdef";
            //for (int i = str.Length-1; i >=0; i--)
            //{
            //    Console.Write(str[i]);
            //}
            //Console.ReadKey();

            //练习2：接收用户输入的一句英文，将其中的单词以反序输出 "hello c sharp" --"sharp c hello"

            //string input = "hello c sharp";
            //char[] sinput = {' '};
            //string[] rinput=input.Split(sinput,StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < rinput.Length/2; i++)
            //{
            //    string temp = rinput[0];
            //    rinput[0]=rinput[rinput.Length-i-1];
            //    rinput[rinput.Length - i - 1] = temp;

            //}
            //string rinputNew = string.Join(" ",rinput);
            //Console.WriteLine(rinputNew);
            //Console.ReadKey();

            //练习3：从Email中提取出用户名和域名 abc@163.com
            //string email = "abc@163.com";
            //int index = email.LastIndexOf("@");
            //string user = email.Substring(0,index);
            //string ad = email.Substring(index+1);
            //Console.WriteLine(user);
            //Console.WriteLine(ad);
            //Console.ReadKey();

             //课上练习4：文本文件中存储了多个文章标题、作者
            //标题和作者之间用若干空格（数量不定）隔开，每行一个
            //标题有的长有的短，输出到控制台的时候最多标题长度10
            //如果超过10，则截取长度8的子串并且最后添加“...”，加一个竖线后输出作者的名字。
            
            //string[] contents = File.ReadAllLines(@"C:\Users\hongmf\Desktop\1.txt",Encoding.Default);
            //Console.ReadKey();





            //练习5:把{"诸葛亮",鸟叔”,"卡卡西",“卡哇伊”}变成诸葛亮|鸟叔|卡卡西|卡哇伊，然后再把|切割掉
            //string[] names={"诸葛亮","鸟叔","卡卡西","卡哇伊"};
            //string strNames = string.Join("|",names);
            //string[] newNames = strNames.Split(new char[] {'|'},StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < newNames.Length; i++)
            //{
            //    Console.WriteLine(newNames[i]);
            //}
            //Console.ReadKey();


            //练习6：让用户输入一句话，找出所有e的位置
            //string str = "sdffefefesdfeessde";
            //int index = str.IndexOf('e');
            //Console.WriteLine("第1次出e的位置是{0}",index);
            ////循环体：从上一次出现e的位置加1的位置找下一次e出现的位置
            ////循环条件：index!=-1
            //int count = 1;//用来记录e出现的次数
            //while (index != -1)
            //{
            //    count++;
            //    index = str.IndexOf('e', index + 1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次出现e的位置是{1}", count, index);

            //}
            //Console.ReadKey();

            //方法二,适用于找单个字符，此处用的char数组
            //string str = "sdffefefesdfeessde";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'e')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();

        }
    }
}
