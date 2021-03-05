using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple.GoodWay
{
    class Mers : IMers
    {
        public string Model { get; set; }
        public void MersSet(string model)
        {
            Model = model;
            Console.WriteLine(model);
        }
    }
}
