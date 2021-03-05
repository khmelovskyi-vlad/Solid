using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple.GoodWay
{
    class Audi : IAudi
    {
        public string Model { get; set; }
        public void AudiSet(string model)
        {
            Model = model;
            Console.WriteLine(model);
        }
    }
}
