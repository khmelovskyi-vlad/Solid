using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.BadWay2
{
    class Footer : IComponent
    {
        public void Render()
        {
            Console.WriteLine("<div>Footer<div>");
        }
    }
}
