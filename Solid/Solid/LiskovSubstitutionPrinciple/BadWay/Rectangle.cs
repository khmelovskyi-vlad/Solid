using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.BadWay
{
    class Rectangle
    {
        private double Height { get; set; }
        private double Width { get; set; }
        public Rectangle()
        {
        }
        public virtual void SetHeight(double height)
        {
            Height = height;
        }
        public virtual void SetWidth(double width)
        {
            Width = width;
        }
        public virtual double GetArea()
        {
            return Height * Width;
        }
    }
}
