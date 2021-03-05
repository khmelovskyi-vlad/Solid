using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.DependencyInversionPrinciple.BadWay
{
    class Http
    {
        public XmlHttpService XmlHttpService { get; set; }
        public NodeHttpService NodeHttpService { get; set; }
        public Http(XmlHttpService xmlHttpService, NodeHttpService nodeHttpService)
        {
            XmlHttpService = xmlHttpService;
            NodeHttpService = nodeHttpService;
        }
        public void Get(string url, string options = null)
        {
            XmlHttpService.Request(url, "GET");
        }
        public void Post(string url)
        {
            XmlHttpService.Request(url, "POST");
        }
        public void NodeGet(string url, string options = null)
        {
            NodeHttpService.Request(url, "GET");
        }
        public void NodePost(string url)
        {
            NodeHttpService.Request(url, "POST");
        }
    }
}
