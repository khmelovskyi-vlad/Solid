using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SingleResponsibilityPrinciple.GoodWay
{
    class GoodsPrinter
    {
        public void PrintHTMLGoods(List<string> goodsList)
        {
            foreach (var goods in goodsList)
            {
                Console.Write($"{goods} ");
            }
            Console.WriteLine();
        }
        public void PrintXMLGoods(List<string> goodsList)
        {
            foreach (var goods in goodsList)
            {
                Console.Write($"{goods} ");
            }
            Console.WriteLine();
        }
        public void PrintConsoleGoods(List<string> goodsList)
        {
            foreach (var goods in goodsList)
            {
                Console.Write($"{goods} ");
            }
            Console.WriteLine();
        }
    }
}
