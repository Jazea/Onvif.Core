using Onvif.Core.Client.Common;

using System;

#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace Onvif.Core.Client
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配
{
    public class CameraFocusRequest : Request
    {
        public FocusMove FocusMove { get; set; }
    }
}
