using Onvif.Core.Discovery.Common;
using Onvif.Core.Discovery.Interfaces;
using Onvif.Core.Discovery.Models;
using Onvif.Core.Internals;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Onvif.Core.Discovery
{
    public class WSDiscovery : IWSDiscovery
    {
        /// <remarks>
        /// This method uses 80 port.
        /// </remarks>
        public Task<IEnumerable<DiscoveryDevice>> Discover(int timeout,
            CancellationToken cancellationToken = default)
        {
            return Discover(timeout, new UdpClientWrapper(), cancellationToken);
        }

        public Task<IEnumerable<DiscoveryDevice>> Discover(int timeout, int port,
           CancellationToken cancellationToken = default)
        {
            return Discover(timeout, new UdpClientWrapper(port), cancellationToken);
        }

        public Task<IEnumerable<DiscoveryDevice>> Discover(int timeout, string ipAddress, int port,
            CancellationToken cancellationToken = default)
        {
            return Discover(timeout, new UdpClientWrapper(ipAddress, port), cancellationToken);
        }

        public async Task<IEnumerable<DiscoveryDevice>> Discover(int Timeout, IUdpClient client,
            CancellationToken cancellationToken = default)
        {
            var devices = new List<DiscoveryDevice>();
            var responses = new List<UdpReceiveResult>();
            await SendProbe(client).ConfigureAwait(false);
            bool isRunning;
            try
            {
                isRunning = true;
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(Timeout));
                while (isRunning)
                {
                    if (cts.IsCancellationRequested || cancellationToken.IsCancellationRequested)
                    {
                        break;
                    }
                    var response = await client.ReceiveAsync().WithCancellation(cts.Token).WithCancellation(cancellationToken).ConfigureAwait(false);
                    responses.Add(response);
                }
            }
            catch (OperationCanceledException)
            {
                isRunning = false;
            }
            finally
            {
                client.Close();
                client.Dispose();
            }
            if (cancellationToken.IsCancellationRequested)
            {
                return devices;
            }
            devices.AddRange(ProcessResponses(responses));
            return devices;
        }

        async Task SendProbe(IUdpClient client)
        {
            var message = WSProbeMessageBuilder.NewProbeMessage();
            var multicastEndpoint = new IPEndPoint(IPAddress.Parse(Constants.WS_MULTICAST_ADDRESS), Constants.WS_MULTICAST_PORT);
            await client.SendAsync(message, message.Length, multicastEndpoint).ConfigureAwait(false);
        }

        IEnumerable<DiscoveryDevice> ProcessResponses(IEnumerable<UdpReceiveResult> responses)
        {
            foreach (var response in responses)
            {
                if (response.Buffer != null)
                {
                    string strResponse = Encoding.UTF8.GetString(response.Buffer);
                    if (strResponse == string.Empty)
                        continue;
                    XmlProbeReponse xmlResponse = DeserializeResponse(strResponse);
                    foreach (var device in CreateDevices(xmlResponse, response.RemoteEndPoint))
                    {
                        yield return device;
                    }
                }
            }
        }

        XmlProbeReponse DeserializeResponse(string xml)
        {
            XmlSerializer serializer = new(typeof(XmlProbeReponse));
            XmlReaderSettings settings = new();
            using StringReader textReader = new(xml);
            using XmlReader xmlReader = XmlReader.Create(textReader, settings);
            return (XmlProbeReponse)serializer.Deserialize(xmlReader);
        }

        IEnumerable<DiscoveryDevice> CreateDevices(XmlProbeReponse response, IPEndPoint remoteEndpoint)
        {
            DiscoveryDevice discoveryDevice;
            foreach (var probeMatch in response.Body.ProbeMatches)
            {
                discoveryDevice = null;
                try
                {
                    ScopesParser.Parse(probeMatch.Scopes, out var name, out var model);

                    discoveryDevice = new DiscoveryDevice
                    {
                        Address = remoteEndpoint.Address,
                        XAdresses = ConvertToList(probeMatch.XAddrs),
                        Types = ConvertToList(probeMatch.Types),
                        Model = model,
                        Name = name
                    };
                }
                catch (Exception ex)
                {
                    Debug.Fail(ex.ToString());
                }
                if (discoveryDevice != null)
                {
                    yield return discoveryDevice;
                }
            }
        }

        IEnumerable<string> ConvertToList(string spacedListString)
        {
            var strings = spacedListString.Split(null);
            foreach (var str in strings)
            {
                yield return str.Trim();
            }
        }
    }
}
