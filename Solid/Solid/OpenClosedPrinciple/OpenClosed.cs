using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OpenClosedPrinciple
{
    class OpenClosed
    {
        public void Run()
        {
            Console.WriteLine("Open/closed principle");
            //bad way
            Console.WriteLine("Bad way:");
            var badShop = new BadWay.Shop(new List<BadWay.Auto>() 
            {
                new BadWay.Auto("BMW"),
                new BadWay.Auto("Audi"),
                new BadWay.Auto("Mers")
            });
            var badPriceCalculator = new BadWay.PriceCalculator();
            var badPrice = badPriceCalculator.GetPrice(badShop.Autos);
            Console.WriteLine(badPrice);

            //good way
            Console.WriteLine("Good way:");
            var goodShop = new GoodWay.Shop(new List<GoodWay.ICarPrice>()
            {
                new GoodWay.BMW(),
                new GoodWay.Audi(),
                new GoodWay.Mers()
            });
            var goodPriceCalculator = new GoodWay.PriceCalculator();
            var goodPrice = goodPriceCalculator.GetPrice(goodShop.Autos);
            Console.WriteLine(goodPrice);
            Console.WriteLine();
        }
    }
}
