using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.DependencyInversionPrinciple
{
    class DependencyInversion
    {
        public void Run()
        {
            Console.WriteLine("Dependency injection principle");
            //bad way
            Console.WriteLine("Bad way:");
            var badXmlHttpService = new BadWay.XmlHttpService();
            var badNodeHttpService = new BadWay.NodeHttpService();
            var badHttp = new BadWay.Http(badXmlHttpService, badNodeHttpService);
            badHttp.Get("url");
            badHttp.Post("url");
            badHttp.NodeGet("url");
            badHttp.NodePost("url");
            //good way
            Console.WriteLine("Good way:");
            var goodXmlHttpService = new GoodWay.XmlHttpService();
            var goodNodeHttpService = new GoodWay.NodeHttpService();
            var goodHttp = new GoodWay.Http(goodXmlHttpService);
            goodHttp.Get("url");
            goodHttp.Post("url");
            goodHttp = new GoodWay.Http(goodNodeHttpService);
            goodHttp.Get("url");
            goodHttp.Post("url");
            Console.WriteLine();
        }
    }
}
