using Onvif.Core.Internals;

using System;


namespace Onvif.Core.Client.Camera
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
