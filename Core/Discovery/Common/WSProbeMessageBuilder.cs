using System;
using System.Text;

namespace Onvif.Core.Discovery.Common
{
    public class WSProbeMessageBuilder
    {
        public static byte[] NewProbeMessage()
        {
            var probeMessagewithguid = string.Format(Constants.WS_PROBE_MESSAGE, Guid.NewGuid().ToString());
            return Encoding.UTF8.GetBytes(probeMessagewithguid);
        }
    }
}
