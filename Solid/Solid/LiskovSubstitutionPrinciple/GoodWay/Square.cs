using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.GoodWay
{
    class Square : IFigure
    {
        private double Side { get; set; }
        public Square()
        {
        }
        public void SetSide(double side)
        {
            Side = side;
        }
        public double GetArea()
        {
            return Side * Side;
        }
    }
}
