using System;
using System.Collections.Generic;
using System.Text;

namespace Onvif.Core.Client
{
    public class Account(string host, string userName, string password)
    {
        public string Host { get; } = host;
        public string UserName { get; } = userName;
        public string Password { get; } = password;
    }
}
