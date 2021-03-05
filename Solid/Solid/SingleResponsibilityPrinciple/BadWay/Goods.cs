using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SingleResponsibilityPrinciple.BadWay
{
    class Goods
    {
        public List<string> GoodsList { get; set; }
        public Goods(List<string> goodsList)
        {
            GoodsList = goodsList;
        }
        public void PrintHTMLGoods()
        {
            foreach (var goods in GoodsList)
            {
                Console.Write($"{goods} ");
            }
            Console.WriteLine();
        }
        public void PrintXMLGoods()
        {
            foreach (var goods in GoodsList)
            {
                Console.Write($"{goods} ");
            }
            Console.WriteLine();
        }
        public void PrintConsoleGoods()
        {
            foreach (var goods in GoodsList)
            {
                Console.Write($"{goods} ");
            }
            Console.WriteLine();
        }
    }
}
