using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SingleResponsibilityPrinciple.GoodWay
{
    class Goods
    {
        public List<string> GoodsList { get; set; }
        public Goods(List<string> goodsList)
        {
            GoodsList = goodsList;
        }
    }
}
