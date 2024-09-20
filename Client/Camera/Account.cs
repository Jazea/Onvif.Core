using Onvif.Core.Internals;

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace Onvif.Core.Client
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配
{
    public class Account(string host, string userName, string password) : IEquatable<Account>
    {
        public string Host { get; } = host;
        public string UserName { get; } = userName;
        public string Password { get; } = password;

        public bool Equals(Account other)
        {
            return other != null && Host == other.Host && UserName == other.UserName && Password == other.Password;
        }

        public override bool Equals(object obj)
        {
            return obj is Account account && Equals(account);
        }

        public override int GetHashCode()
        {
            Fnv1aImpl fnv1 = new();
            fnv1.AppendObj(Host)
                .AppendObj(UserName)
                .AppendObj(Password);
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Host}:{UserName}:{Password}";
        }
    }
}
