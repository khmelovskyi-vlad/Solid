using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.BadWay
{
    class SizeShaper
    {
        public void ChangeRectangleShapeSize(Rectangle rectangle, double height, double width)
        {
            rectangle.SetHeight(height);
            rectangle.SetWidth(width);
        }
    }
}
