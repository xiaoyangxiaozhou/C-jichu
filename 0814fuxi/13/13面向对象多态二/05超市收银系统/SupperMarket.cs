using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05超市收银系统
{
    class SupperMarket
    {
        //创建仓库对象
        CangKu ck = new CangKu();

        /// <summary>
        /// 创建超市对象的时候，给仓库的货架上导入货物
        /// </summary>
        public SupperMarket()
        {
            ck.JinPros("Acer",100);
            ck.JinPros("SamSung",100);
            ck.JinPros("JiangYou",100);
            ck.JinPros("Banana",100);
        }

        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问您需要些什么");
            Console.WriteLine("我们有Acer、SamSung、JiangYou、Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货物
            ProductFather[] pros = ck.QuPros(strType,count);
            //下面该计算价钱了
            double realMoney = GetMoney(pros);
            Console.WriteLine("您总共应付{0}元",realMoney);
            Console.WriteLine("请选择您的打折方式 1--不打折 2--打9折 3--打85折 4--买300减50 5--买500减100");
            string input = Console.ReadLine();
            CalFather cal = GetCal(input);
            double totalMoney=cal.GetTotalMoney(realMoney);
            Console.WriteLine("打完折后，您应付{0}元",totalMoney);
            Console.WriteLine("以下是您的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称："+item.Name+","+"货物单价:"+item.Price+","+"货物编号:"+item.ID);
            }

        }
 
        /// <summary>
        /// 根据用户的选择打折方式 返回一个打折对象
        /// </summary>
        /// <param name="input">用户的选择</param>
        /// <returns>返回的父类对象 但是里面装的是子类对象</returns>
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1": cal = new CalNormal();
                    break;
                case "2": cal = new CalRate(0.9);
                    break;
                case "3": cal = new CalRate(0.85);
                    break;
                case "4": cal = new CalMN(300,50);
                    break;
                case "5": cal = new CalMN(500, 100);
                    break;

            }
            return cal;
        
        }
        /// <summary>
        /// 根据用户买的货物计算总价钱
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }

        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
