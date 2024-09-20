using Onvif.Core.Discovery.Interfaces;

using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Onvif.Core.Discovery.Common
{
    /// <summary>
    /// A simple <see cref="System.Net.Sockets.UdpClient"/> wrapper
    /// </summary>
    public class UdpClientWrapper : IUdpClient
    {
        private readonly UdpClient client;
        private bool _disposedValue;

        /// <remarks>
        /// This ctor. uses port 80 by default.
        /// </remarks>
        public UdpClientWrapper() : this(IPAddress.Any, 80)
        {
        }

        public UdpClientWrapper(int port) : this(IPAddress.Any, port)
        {
        }

        public UdpClientWrapper(string ipAddress, int port) : this(IPAddress.Parse(ipAddress), port)
        {
        }

        public UdpClientWrapper(IPAddress ipAddress, int port) : this(new IPEndPoint(ipAddress, port))
        {
        }

        public UdpClientWrapper(IPEndPoint localEndPoint)
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();
            foreach (IPEndPoint item in ipEndPoints)
            {
                if (item.AddressFamily == localEndPoint.AddressFamily
                    && (localEndPoint.Address.Equals(IPAddress.Any) || localEndPoint.Address.Equals(IPAddress.Any) || item.Address.Equals(localEndPoint.Address))
                    && item.Port == localEndPoint.Port)
                {
                    throw new ArgumentException($"Port {localEndPoint.Port}");
                }
            }
            client = new UdpClient(localEndPoint)
            {
                EnableBroadcast = true
            };
        }

        public async Task<int> SendAsync(byte[] datagram, int bytes, IPEndPoint endPoint)
        {
            return await client.SendAsync(datagram, bytes, endPoint).ConfigureAwait(false);
        }

        public async Task<UdpReceiveResult> ReceiveAsync()
        {
            return await client.ReceiveAsync().ConfigureAwait(false);
        }

        public void Close()
        {
            client.Close();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    client?.Dispose();
                }
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}
