using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OpenClosedPrinciple.BadWay
{
    class PriceCalculator
    {
        public decimal GetPrice(List<Auto> autos)
        {
            decimal price = 0;
            for (int i = 0; i < autos.Count; i++)
            {
                switch (autos[i].Model)
                {
                    case "BMW":
                        price += 100000;
                        break;
                    case "Audi":
                        price += 150000;
                        break;
                    case "Mers":
                        price += 200000;
                        break;
                    default:
                        break;
                }
            }
            return price;
        }
    }
}
