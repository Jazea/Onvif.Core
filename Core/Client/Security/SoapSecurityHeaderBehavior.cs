using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Onvif.Core.Client.Security
{
    public class SoapSecurityHeaderBehavior : IEndpointBehavior
    {
        private readonly string username;
        private readonly string password;
        private readonly TimeSpan timeShift;

        public SoapSecurityHeaderBehavior(string username, string password) : this(username, password, TimeSpan.FromMilliseconds(0))
        {
        }

        public SoapSecurityHeaderBehavior(string username, string password, TimeSpan timeShift)
        {
            this.username = username;
            this.password = password;
            this.timeShift = timeShift;
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {

        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.ClientMessageInspectors.Add(new SoapSecurityHeaderInspector(username, password, timeShift));
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {

        }

        public void Validate(ServiceEndpoint endpoint)
        {

        }
    }
}
