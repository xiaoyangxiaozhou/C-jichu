using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05超市收银系统
{
    class Banana:ProductFather
    {
        public Banana(string id, double price,string name)
            : base(id, price,name)
        { 
        
        }
    }
}
