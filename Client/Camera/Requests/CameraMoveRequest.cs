using Onvif.Core.Client.Common;

namespace Onvif.Core.Client.Camera.Requests;

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
