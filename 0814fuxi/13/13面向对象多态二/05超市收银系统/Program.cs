﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05超市收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建超市对象
            SupperMarket sm = new SupperMarket();
            //展示货物
            sm.ShowPros();
            sm.AskBuying();
            Console.ReadKey();

        }
    }
}
