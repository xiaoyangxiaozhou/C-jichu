using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //从一个整数数组中取出最大整数，最小整数，总和，平均值
            //int[] nums = {1,3,5,7,5,0,8,2 };
            //int max = nums[0];
            //int min =nums[0];
            //int sum=0;
            //for (int i = 0; i <nums.Length; i++)
            //{
            //    sum+=nums[i];
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //    if (nums[i] < min)
            //    {

            //        min = nums[i];
            //    }
            //}
            //Console.WriteLine("该数组的最大整数为{0},最小整数为{1}，总和为{2},平均值为{3}",max,min,sum,sum/nums.Length);
            //Console.ReadKey();
            #endregion

            #region
            //数组里面都是人的名字，分割成:例如:老杨|老苏|老邹.....(老杨，老苏，老邹，老牛，老朱)
            //string[] str = { "老杨", "老苏", "老邹", "老牛", "老朱" };
            //string name = "";
            //for (int i = 0; i < str.Length-1; i++)
            //{
            //    name += str[i] + "|";
                
            //}
            //Console.Write(name+str[str.Length-1]);
            //Console.ReadKey();

            //将一个整数数组的每一个元素进行如下处理：
            //如果元素是正数则将这个位置的元素的值加1；如果元素是负数则将这个位置的元素的值减1，如果是0，则不变

            //int[] nums = { -1, -2, -3, -4, 0, 1, 2, 3, 4 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(nums[i]<0)
            //    {
            //        nums[i]-=1;
            //    }
            //    else if (nums[i] > 0)
            //    {
            //        nums[i] += 1;
            //    }
            //    else
            //    {
            //        nums[i] = 0;
            //    }
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            //将一个字符串数组的元素的顺序进行反转。{"我"，“是”，“好人”}  ｛“好人”“是”“我”｝
            //string[] str = {"我","是","好人" };
           
            //for (int i = 0; i < str.Length/2; i++)
            //{
            //    string temp = str[i];
            //    str[i] = str[str.Length - 1 - i];
            //    str[str.Length - 1 - i] = temp;

                
            //}
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //Console.ReadKey();
            #endregion

            //计算两个整数之间的最大值
            int max=Program.GetMax(10, 2);
            Console.WriteLine(max);
            Console.ReadKey();


        }

        /// <summary>
        /// 计算两个整数之间的最大值并将最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>将最大值返回</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        
        }
    }
}
