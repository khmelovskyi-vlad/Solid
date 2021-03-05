using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple.GoodWay2
{
    interface IComponentWithTemplate : IComponent
    {
        void Render();
    }
}
