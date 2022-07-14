using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Onvif.Core.Client.Common;
using Onvif.Core.Client.Device;
using Onvif.Core.Client.Imaging;
using Onvif.Core.Client.Media;
using Onvif.Core.Client.Ptz;
using Onvif.Core.Client.Security;

namespace Onvif.Core.Client
{
    public static class OnvifClientFactory
    {
        static Binding CreateBinding()
        {
            var binding = new CustomBinding();
            var textBindingElement = new TextMessageEncodingBindingElement
            {
                MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None)
            };
            var httpBindingElement = new HttpTransportBindingElement
            {
                AllowCookies = true,
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue
            };

            binding.Elements.Add(textBindingElement);
            binding.Elements.Add(httpBindingElement);

            return binding;
        }

        public static async Task<DeviceClient> CreateDeviceClientAsync(string host, string username, string password)
        {
            return await CreateDeviceClientAsync(new Uri($"http://{host}/onvif/device_service"), username, password);
        }

        public static async Task<DeviceClient> CreateDeviceClientAsync(Uri uri, string username, string password)
        {
            var binding = CreateBinding();
            var endpoint = new EndpointAddress(uri);
            var device = new DeviceClient(binding, endpoint);
            var time_shift = await GetDeviceTimeShift(device);

            device = new DeviceClient(binding, endpoint);
            device.ChannelFactory.Endpoint.EndpointBehaviors.Clear();
            device.ChannelFactory.Endpoint.EndpointBehaviors.Add(new SoapSecurityHeaderBehavior(username, password, time_shift));

            // Connectivity Test
            await device.OpenAsync();

            return device;
        }

        public static async Task<MediaClient> CreateMediaClientAsync(string host, string username, string password)
        {
            var binding = CreateBinding();
            var device = await CreateDeviceClientAsync(host, username, password);
            var caps = await device.GetCapabilitiesAsync(new CapabilityCategory[] { CapabilityCategory.Media });
            var media = new MediaClient(binding, new EndpointAddress(new Uri(caps.Capabilities.Media.XAddr)));

            var time_shift = await GetDeviceTimeShift(device);
            media.ChannelFactory.Endpoint.EndpointBehaviors.Clear();
            media.ChannelFactory.Endpoint.EndpointBehaviors.Add(new SoapSecurityHeaderBehavior(username, password, time_shift));

            // Connectivity Test
            await media.OpenAsync();

            return media;
        }

        public static async Task<PTZClient> CreatePTZClientAsync(string host, string username, string password)
        {
            var binding = CreateBinding();
            var device = await CreateDeviceClientAsync(host, username, password);
            var caps = await device.GetCapabilitiesAsync(new CapabilityCategory[] { CapabilityCategory.PTZ });
            var ptz = new PTZClient(binding, new EndpointAddress(new Uri(caps.Capabilities.PTZ.XAddr)));

            var time_shift = await GetDeviceTimeShift(device);
            ptz.ChannelFactory.Endpoint.EndpointBehaviors.Clear();
            ptz.ChannelFactory.Endpoint.EndpointBehaviors.Add(new SoapSecurityHeaderBehavior(username, password, time_shift));

            // Connectivity Test
            await ptz.OpenAsync();

            return ptz;
        }

        public static async Task<ImagingClient> CreateImagingClientAsync(string host, string username, string password)
        {
            var binding = CreateBinding();
            var device = await CreateDeviceClientAsync(host, username, password);
            var caps = await device.GetCapabilitiesAsync(new CapabilityCategory[] { CapabilityCategory.Imaging });
            var imaging = new ImagingClient(binding, new EndpointAddress(new Uri(caps.Capabilities.Imaging.XAddr)));

            var time_shift = await GetDeviceTimeShift(device);
            imaging.ChannelFactory.Endpoint.EndpointBehaviors.Clear();
            imaging.ChannelFactory.Endpoint.EndpointBehaviors.Add(new SoapSecurityHeaderBehavior(username, password, time_shift));

            // Connectivity Test
            await imaging.OpenAsync();

            return imaging;
        }

        public static async Task<TimeSpan> GetDeviceTimeShift(this DeviceClient device)
        {
            var utc = (await device.GetSystemDateAndTimeAsync()).UTCDateTime;
            var dt = new System.DateTime(utc.Date.Year, utc.Date.Month, utc.Date.Day,
                              utc.Time.Hour, utc.Time.Minute, utc.Time.Second);
            return dt - System.DateTime.UtcNow;
        }
    }
}
