using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OpenClosedPrinciple.GoodWay
{
    class Shop
    {
        public List<ICarPrice> Autos { get; set; }
        public Shop(List<ICarPrice> autos)
        {
            Autos = autos;
        }
    }
}
