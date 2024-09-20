using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace Onvif.Core.Client
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配
{
    public class Account(string host, string userName, string password)
    {
        public string Host { get; } = host;
        public string UserName { get; } = userName;
        public string Password { get; } = password;
    }
}
