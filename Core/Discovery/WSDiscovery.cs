using Onvif.Core.Discovery.Common;
using Onvif.Core.Discovery.Interfaces;
using Onvif.Core.Discovery.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Onvif.Core.Discovery
{
    public class WSDiscovery : IWSDiscovery
    {
        public Task<IEnumerable<DiscoveryDevice>> Discover(int timeout,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return Discover(timeout, new UdpClientWrapper(), cancellationToken);
        }

        public async Task<IEnumerable<DiscoveryDevice>> Discover(int Timeout, IUdpClient client,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var devices = new List<DiscoveryDevice>();
            var isRunning = false;
            var responses = new List<UdpReceiveResult>();

            await SendProbe(client);
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
                    var response = await client.ReceiveAsync().WithCancellation(cts.Token).WithCancellation(cancellationToken);
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
            await client.SendAsync(message, message.Length, multicastEndpoint);
        }

        IEnumerable<DiscoveryDevice> ProcessResponses(IEnumerable<UdpReceiveResult> responses)
        {
            foreach (var response in responses)
            {
                if (response.Buffer != null)
                {
                    string strResponse = Encoding.UTF8.GetString(response.Buffer);
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
            XmlSerializer serializer = new XmlSerializer(typeof(XmlProbeReponse));
            XmlReaderSettings settings = new XmlReaderSettings();
            using (StringReader textReader = new StringReader(xml))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    return (XmlProbeReponse)serializer.Deserialize(xmlReader);
                }
            }
        }

        IEnumerable<DiscoveryDevice> CreateDevices(XmlProbeReponse response, IPEndPoint remoteEndpoint)
        {
            foreach (var probeMatch in response.Body.ProbeMatches)
            {
                var discoveryDevice = new DiscoveryDevice();
                discoveryDevice.Address = remoteEndpoint.Address;
                discoveryDevice.XAdresses = ConvertToList(probeMatch.XAddrs);
                discoveryDevice.Types = ConvertToList(probeMatch.Types);
                discoveryDevice.Model = ParseModelFromScopes(probeMatch.Scopes);
                discoveryDevice.Name = ParseNameFromScopes(probeMatch.Scopes);
                yield return discoveryDevice;
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

        string ParseModelFromScopes(string scopes)
        {
            return Regex.Match(scopes, "(?<=hardware/).*?(?= )").Value;
        }

        string ParseNameFromScopes(string scopes)
        {
            return Regex.Match(scopes, "(?<=name/).*?(?= )").Value;
        }
    }
}
