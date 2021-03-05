using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SingleResponsibilityPrinciple
{
    public class SingleResponsibility
    {
        public void Run()
        {
            Console.WriteLine("Single responsibility principle");
            //Bad way
            Console.WriteLine("Bad way:");
            var badGoods = new BadWay.Goods(new List<string>() { "BMV", "Audi", "Mers" });
            badGoods.PrintHTMLGoods();
            badGoods.PrintXMLGoods();
            badGoods.PrintConsoleGoods();

            //Good way
            Console.WriteLine("Good way:");
            var goodGoods = new GoodWay.Goods(new List<string>() { "BMV", "Audi", "Mers" });
            var goodsPrinter = new GoodWay.GoodsPrinter();
            goodsPrinter.PrintHTMLGoods(goodGoods.GoodsList);
            goodsPrinter.PrintXMLGoods(goodGoods.GoodsList);
            goodsPrinter.PrintConsoleGoods(goodGoods.GoodsList);
            Console.WriteLine();
        }
    }
}
