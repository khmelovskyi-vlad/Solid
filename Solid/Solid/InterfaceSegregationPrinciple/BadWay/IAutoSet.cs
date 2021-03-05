using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple.BadWay
{
    interface IAutoSet
    {
        void AudiSet(string model);
        void BMWSet(string model);
        void MersSet(string model);
    }
}
