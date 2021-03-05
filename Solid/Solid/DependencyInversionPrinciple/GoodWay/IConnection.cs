using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.DependencyInversionPrinciple.GoodWay
{
    interface IConnection
    {
        void Request(string uml, string type);
    }
}
