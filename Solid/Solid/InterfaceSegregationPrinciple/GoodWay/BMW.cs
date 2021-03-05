using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple.GoodWay
{
    class BMW : IBMW
    {
        public string Model { get; set; }
        public void BMWSet(string model)
        {
            Model = model;
            Console.WriteLine(model);
        }
    }
}
