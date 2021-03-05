using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OpenClosedPrinciple.GoodWay
{
    class PriceCalculator
    {
        public decimal GetPrice(List<ICarPrice> autos)
        {
            decimal price = 0;
            for (int i = 0; i < autos.Count; i++)
            {
                price += autos[i].GetPrice();
            }
            return price;
        }
    }
}
