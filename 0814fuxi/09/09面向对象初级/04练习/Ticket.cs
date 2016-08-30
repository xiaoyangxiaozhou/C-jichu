using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04练习
{
    public class Ticket
    {
        //写一个Ticket类，有一个距离属性（本属性只读，在构造方法中赋值）
       //不能为负数，有一个价格属性，价格属性只读，并且根据距离distance计算价格(1元/公里)
        //0-100公里  票价不打折
        //101-200公里 总额打9.5折
        //201-300公里 总额打9折
        //300公里以上 总额打8折
        //public Ticket(double distance)
        //{
        //    if (distance < 0)
        //    {
        //        distance = 0;
        //    }
        //    this._distance = distance;
        //}
        
        //private double _price;
        //public double Price
        //{ 
        //    get{
        //        if (_distance > 0 && _distance <= 100)
        //        {
        //            return _distance * 1.0;
        //        }
        //        else if (_distance > 100 && _distance <= 200)
        //        {
        //            return _distance * 0.95;
        //        }
        //        else if (_distance > 200)
        //        {
        //            return _distance * 0.9;
        //        }
        //        else
        //        {
        //            return _distance * 0.8;
        //        }
        //    }
        //}

        //private double _distance;

        //public double Distance
        //{
        //    get { return _distance; }
        //}

        //public void ShowTicket()
        //{
        //    Console.WriteLine("{0}公里的价格为{1}",this.Distance,this.Price);
        //}
    }
}
