using System;
using System.Net;

namespace ProxyInjector
{
    public class ProxyInjector : IWebProxy
    {
        public ICredentials Credentials
        {
            get => new NetworkCredential("userName", "password");
            set { }
        }

        public Uri GetProxy(Uri destination)
        {
            return new Uri("<proxy URI goes here>");
        }

        public bool IsBypassed(Uri host)
        {
            return false;
        }
    }
}
