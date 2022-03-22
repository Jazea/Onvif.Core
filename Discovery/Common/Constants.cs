
namespace Onvif.Core.Discovery.Common
{
    public class Constants
    {
        public const int WS_TIMEOUT = 5000;
        public const string WS_MULTICAST_ADDRESS = "239.255.255.250";
        public const int WS_MULTICAST_PORT = 3702;
        public const string WS_PROBE_MESSAGE =
// "<?xml version=\"1.0\" encoding=\"UTF-8\"?>"
// + "<e:Envelope xmlns:e=\"http://www.w3.org/2003/05/soap-envelope\""
// + "xmlns:w=\"http://schemas.xmlsoap.org/ws/2004/08/addressing\""
// + "xmlns:d=\"http://schemas.xmlsoap.org/ws/2005/04/discovery\""
// + "xmlns:tds=\"https://www.onvif.org/ver10/device/wsdl/devicemgmt.wsdl\""
// + "xmlns:dn=\"http://www.onvif.org/ver10/network/wsdl\">"
// + "<e:Header>"
// + "<w:MessageID>uuid:{0}</w:MessageID>"
// + "<w:To>urn:schemas-xmlsoap-org:ws:2005:04:discovery</w:To> "
// + "<w:Action>http://schemas.xmlsoap.org/ws/2005/04/discovery/Probe</w:Action>"
// + "</e:Header>"
// + "<e:Body>"
// + "<d:Probe><d:Types>dn:NetworkVideoTransmitter</d:Types></d:Probe>"
// + "</e:Body>"
// + "</e:Envelope>";

@"<?xml version=""1.0"" encoding=""UTF-8""?>
<e:Envelope xmlns:e=""http://www.w3.org/2003/05/soap-envelope""
xmlns:w=""http://schemas.xmlsoap.org/ws/2004/08/addressing""
xmlns:d=""http://schemas.xmlsoap.org/ws/2005/04/discovery""
xmlns:dn=""http://www.onvif.org/ver10/network/wsdl"">
<e:Header>
<w:MessageID>uuid:{0}</w:MessageID>
<w:To e:mustUnderstand=""true"">urn:schemas-xmlsoap-org:ws:2005:04:discovery</w:To>
<w:Action
a:mustUnderstand=""true"">http://schemas.xmlsoap.org/ws/2005/04/discovery/Pr
obe</w:Action>
</e:Header>
<e:Body>
<d:Probe>
<d:Types>dn:NetworkVideoTransmitter</d:Types>
</d:Probe>
</e:Body>
</e:Envelope>";
    }
}
