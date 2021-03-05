using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple.BadWay
{
    class BMW : IAutoSet
    {
        public string Model { get; set; }
        public void AudiSet(string model)
        {
            Console.WriteLine("Error");
        }

        public void BMWSet(string model)
        {
            Model = model;
            Console.WriteLine(model);
        }

        public void MersSet(string model)
        {
            Console.WriteLine("Error");
        }
    }
}
