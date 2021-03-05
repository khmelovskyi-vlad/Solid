using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple.BadWay
{
    class Mers : IAutoSet
    {
        public string Model { get; set; }
        public void AudiSet(string model)
        {
            Console.WriteLine("Error");
        }

        public void BMWSet(string model)
        {
            Console.WriteLine("Error");
        }

        public void MersSet(string model)
        {
            Model = model;
            Console.WriteLine(model);
        }
    }
}
