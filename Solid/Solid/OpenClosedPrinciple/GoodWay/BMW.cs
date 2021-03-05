using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OpenClosedPrinciple.GoodWay
{
    class BMW : ICarPrice
    {
        public decimal GetPrice()
        {
            return 100000;
        }
    }
}
