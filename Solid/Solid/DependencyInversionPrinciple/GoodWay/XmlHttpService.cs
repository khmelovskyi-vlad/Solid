using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.DependencyInversionPrinciple.GoodWay
{
    class XmlHttpService : IConnection
    {
        public void Request(string uml, string type)
        {
            Console.WriteLine($"Uml: {uml}, Type: {type}");
        }
    }
}
