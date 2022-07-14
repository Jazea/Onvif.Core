using System;
using System.Collections.Generic;
using System.Text;

namespace Onvif.Core.Client
{
    public class Account
    {
        public Account(string host, string userName, string password)
        {
            Host = host;
            UserName = userName;
            Password = password;
        }
        public string Host { get; }
        public string UserName { get; }
        public string Password { get; }
    }
}
