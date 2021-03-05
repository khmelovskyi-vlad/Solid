using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.GoodWay2
{
    class Header : IComponentWithTemplate
    {
        public void Render()
        {
            Console.WriteLine("<div>Header<div>");
        }
    }
}
