using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.DependencyInversionPrinciple.GoodWay
{
    class Http
    {
        public IConnection Connection { get; set; }
        public Http(IConnection connection)
        {
            Connection = connection;
        }
        public void Get(string url, string options = null)
        {
            Connection.Request(url, "GET");
        }
        public void Post(string url)
        {
            Connection.Request(url, "POST");
        }
    }
}
