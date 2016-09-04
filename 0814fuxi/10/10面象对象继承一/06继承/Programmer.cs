using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06继承
{
   
    public class Programmer:Person
    {
        public Programmer(string name, int age, char gender, int workYear)
            : base(name, age, gender)
        {
            this.WorkYear = workYear;
        }

        private int _workYear;
        public int WorkYear
        {
            get { return _workYear; }
            set { _workYear = value; }
        }

        public void ProgrammerSayHello()
        {
            Console.WriteLine("我叫{0}，我是一名程序员，我是{1}生，我今年{2}岁了，我的工作年限是{3}年",this.Name,this.Gengder,this.Age,this.WorkYear);
        }

    }
}
