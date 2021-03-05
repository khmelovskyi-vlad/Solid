using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.GoodWay2
{
    class Footer : IComponentWithTemplate
    {
        public void Render()
        {
            Console.WriteLine("<div>Footer<div>");
        }
    }
}
