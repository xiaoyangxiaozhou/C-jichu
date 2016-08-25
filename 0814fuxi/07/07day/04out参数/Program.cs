using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            ////写一个方法 求一个数组中的最大值、最小值、总和、平均值
            #region
            //int[] nums = { 1,2,3,4,5,6,7,8,9 };
            ////将要返回的四个值放在数组中返回
            //int[] getnums=GetMaxMinSumAvg(nums);
            //Console.WriteLine("最大值是{0},最小值是{1},总和是{2},平均值是{3}",getnums[0],getnums[1],getnums[2],getnums[3]);
            //Console.ReadKey();
            #endregion

            //int[] nums = {1,2,3,4,5,6,7,8,9 };
            //int max = 0; //也可以不赋初值
            //int min = 0;
            //int sum ;
            //int avg ;

            //Test(nums, out max, out min, out sum, out avg);
            //Console.WriteLine("最大值是{0},最小值是{1},总和是{2},平均值是{3}",max,min,sum,avg);
            //Console.ReadKey();
        }

        #region
        /// <summary>
        /// 求一个数组中的最大值、最小值、总和、平均值，用数组的方式返回这四个值
        /// </summary>
        /// <param name="nums">要被求最大值、最小值、总和、平均值的数组</param>
        /// <returns>返回最大值、最小值、总和、平均值的数组</returns>
        //public static int[] GetMaxMinSumAvg(int[] nums)
        //{
        //    int[] getnums = new int[4];
        //    getnums[0] = nums[0];//max
        //    getnums[1] = nums[0];//min
        //    getnums[2]= 0;//sum
        //    getnums[3]= 0;//avg
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        getnums[2] += nums[i];
        //        if (nums[i] > getnums[0])
        //        {
        //            getnums[0] = nums[i];
        //        }
        //        if (nums[i] < getnums[1])
        //        {
        //            getnums[1] = nums[i];
        //        }
        //    }
        //    getnums[3] = getnums[2] / nums.Length;
        //    return getnums;

        //}
        #endregion

        /// <summary>
        /// 求一个数组中的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums">要求值的数组</param>
        /// <param name="max">多余回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="sum">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>
        //public static void Test(int[] nums, out int max, out int min, out int sum, out int avg)
        //{ 
        //    //out参数要求在方法内部必须为其赋值
        //    max = nums[0];
        //    min = nums[0];
        //    sum = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] > max)
        //        {
        //            max = nums[i];
        //        }
        //        if (nums[i] < min)
        //        {
        //            min = nums[i];
        //        }
        //        sum += nums[i];
        //    }
        //    avg = sum / nums.Length;
        //}

    }
}
