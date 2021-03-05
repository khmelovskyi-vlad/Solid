using Solid.DependencyInversionPrinciple;
using Solid.InterfaceSegregationPrinciple;
using Solid.LiskovSubstitutionPrinciple;
using Solid.OpenClosedPrinciple;
using Solid.SingleResponsibilityPrinciple;
using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleResponsibility = new SingleResponsibility();
            singleResponsibility.Run();
            var openClosed = new OpenClosed();
            openClosed.Run();
            var liskovSubstitution = new LiskovSubstitution();
            liskovSubstitution.Run();
            var interfaceSegregation = new InterfaceSegregation();
            interfaceSegregation.Run();
            var dependencyInjection = new DependencyInversion();
            dependencyInjection.Run();
        }
    }
}
