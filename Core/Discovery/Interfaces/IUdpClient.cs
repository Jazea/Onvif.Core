using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Onvif.Core.Discovery.Interfaces
{
	/// <summary>
	/// UDP Client interface to wrapp UdpClient and easily mock <see cref="System.Net.Sockets.UdpClient"/> in tests
	/// </summary>
	public interface IUdpClient
	{
		Task<int> SendAsync (byte[] datagram, int bytes, IPEndPoint endPoint);
		Task<UdpReceiveResult> ReceiveAsync ();
		void Close ();
	}
}
