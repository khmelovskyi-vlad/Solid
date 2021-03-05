using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OpenClosedPrinciple.GoodWay
{
    class Audi : ICarPrice
    {
        public decimal GetPrice()
        {
            return 150000;
        }
    }
}
