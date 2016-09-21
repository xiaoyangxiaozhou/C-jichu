using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05超市收银系统
{
    /// <summary>
    /// 打折的父类
    /// </summary>
    abstract class CalFather
    {
        /// <summary>
        /// 计算打折后应付的钱
        /// </summary>
        /// <param name="realMoney">打折前应付的价钱</param>
        /// <returns>返回打折后应付的钱</returns>
        public abstract double GetTotalMoney(double realMoney);
    }
}
