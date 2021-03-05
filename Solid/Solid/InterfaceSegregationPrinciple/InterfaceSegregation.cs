using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple
{
    class InterfaceSegregation
    {
        public void Run()
        {
            Console.WriteLine("Interface segregation principle");
            //bad way
            Console.WriteLine("Bad way:");
            BadWay.IAutoSet badAudi = new BadWay.Audi();
            BadWay.IAutoSet badBMW = new BadWay.BMW();
            BadWay.IAutoSet badMers = new BadWay.Mers();
            badAudi.AudiSet("Audi");
            badAudi.BMWSet("Audi");
            badAudi.MersSet("Audi");
            badBMW.AudiSet("BMW");
            badBMW.BMWSet("BMW");
            badBMW.MersSet("BMW");
            badMers.AudiSet("Mers");
            badMers.BMWSet("Mers");
            badMers.MersSet("Mers");
            //good way
            Console.WriteLine("Good way:");
            GoodWay.IAudi goodAudi = new GoodWay.Audi();
            GoodWay.IBMW goodBMW = new GoodWay.BMW();
            GoodWay.IMers goodMers = new GoodWay.Mers();
            goodAudi.AudiSet("Audi");
            goodBMW.BMWSet("BMW");
            goodMers.MersSet("Mers");
            Console.WriteLine();
        }
    }
}
