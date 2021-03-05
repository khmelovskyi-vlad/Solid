using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OpenClosedPrinciple.BadWay
{
    class Shop
    {
        public List<Auto> Autos { get; set; }
        public Shop(List<Auto> autos)
        {
            Autos = autos;
        }
    }
}
