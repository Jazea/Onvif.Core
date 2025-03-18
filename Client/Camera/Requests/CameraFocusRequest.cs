using Onvif.Core.Client.Common;

namespace Onvif.Core.Client.Camera.Requests;

public class CameraFocusRequest : Request
{
    public FocusMove FocusMove { get; set; }
}
