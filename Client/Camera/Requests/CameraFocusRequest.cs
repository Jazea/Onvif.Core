using Onvif.Core.Client.Common;
using System;

namespace Onvif.Core.Client
{
    public class CameraFocusRequest : Request
    {
        public FocusMove FocusMove { get; set; }
    }
}
