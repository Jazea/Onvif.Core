using Onvif.Core.Client.Common;

using System;

#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace Onvif.Core.Client
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配
{
    public enum MoveType
    {
        Absolute,
        Relative,
        Continuous
    }
    public class CameraMoveRequest : Request
    {
        public MoveType MoveType { get; set; }
        public PTZVector Vector { get; set; }
        public PTZSpeed Speed { get; set; }
        public int Timeout { get; set; } //Continuous Move... (ms)
    }
}
