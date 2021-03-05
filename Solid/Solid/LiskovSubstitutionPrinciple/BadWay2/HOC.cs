using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.BadWay2
{
    class HOC : IComponent
    {
        public void Render()
        {
            Console.WriteLine("<div>Error<div>");
        }
    }
}
