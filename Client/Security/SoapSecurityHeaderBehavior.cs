using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Onvif.Core.Client.Security {
	public class SoapSecurityHeaderBehavior : IEndpointBehavior {
		readonly string username;
		readonly string password;
		readonly TimeSpan time_shift;

		public SoapSecurityHeaderBehavior (string username, string password) : this (username, password, TimeSpan.FromMilliseconds (0))
		{
		}

		public SoapSecurityHeaderBehavior (string username, string password, TimeSpan timeShift)
		{
			this.username = username;
			this.password = password;
			time_shift = timeShift;
		}

		public void AddBindingParameters (ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
		{

		}

		public void ApplyClientBehavior (ServiceEndpoint endpoint, ClientRuntime clientRuntime)
		{
			clientRuntime.ClientMessageInspectors.Add (new SoapSecurityHeaderInspector (username, password, time_shift));
		}

		public void ApplyDispatchBehavior (ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
		{

		}

		public void Validate (ServiceEndpoint endpoint)
		{

		}
	}
}
