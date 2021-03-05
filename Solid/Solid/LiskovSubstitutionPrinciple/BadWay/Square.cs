using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.BadWay
{
    class Square : Rectangle
    {
        private double Height { get; set; }
        private double Width { get; set; }
        public Square() : base()
        {
        }
        public override void SetHeight(double height)
        {
            Height = height;
            Width = height;
        }
        public override void SetWidth(double width)
        {
            Width = width;
            Height = width;
        }
        public override double GetArea()
        {
            return Height * Width;
        }
    }
}
