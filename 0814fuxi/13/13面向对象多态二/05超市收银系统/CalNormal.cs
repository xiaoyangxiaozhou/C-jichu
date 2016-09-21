using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05超市收银系统
{
    /// <summary>
    /// 不打折
    /// </summary>
    class CalNormal:CalFather
    {
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
