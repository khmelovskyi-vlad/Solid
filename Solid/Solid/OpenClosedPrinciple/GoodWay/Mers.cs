using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OpenClosedPrinciple.GoodWay
{
    class Mers : ICarPrice
    {
        public decimal GetPrice()
        {
            return 200000;
        }
    }
}
