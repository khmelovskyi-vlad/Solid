using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.BadWay2
{
    class Header : IComponent
    {
        public void Render()
        {
            Console.WriteLine("<div>Header<div>");
        }
    }
}
