using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11方法综合练习14
{
    class Program
    {
        static void Main(string[] args)
        {
            ////计算任意多个数间的最大值(提示params)
            //int[] nums = { 10, 89, 56, 24, 12 };
            //int max = GetMax(10, 89, 56, 24, 12);
            //Console.WriteLine(max);

            //Console.ReadKey();

            //用冒泡排序法对整数数组{1,2,5,3,9,2,4,6,8,10}
            //int[] nums = { 1, 2, 5, 3, 9, 2, 4, 6, 8, 10 };
            //GetOrder(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);

            //}
            //Console.ReadKey();


            //将一个字符串数组输出为|分割的形式，比如"梅西|卡卡| 郑大世"(用方法来实现此功能）
            //string[] names = {"梅西","卡卡","郑大世" };
            //string result = Process(names);
            //Console.WriteLine(result);
            //Console.ReadKey();

        }
        //public static int GetMax(params int[] nums)
        //{
        //    int max = nums[0];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] > max)
        //        {
        //            max = nums[i];
        //        }
                
        //    }
        //    return max;
        //}

        //public static void GetOrder(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = 0; j < nums.Length-1; j++)
        //        {
        //            if (nums[j] > nums[j + 1])
        //            {
        //                int temp = nums[j];
        //                nums[j] = nums[j + 1];
        //                nums[j + 1] = temp;
        //            }
        //        }
        //    }

        //}


        //public static string Process(string[] names)
        //{
        //    string str =null;
        //    for (int i = 0; i < names.Length-1; i++)
        //    {
        //        str += names[i] + "|";
        //    }
        //    return str + names[names.Length - 1];
        //}
    }
}
