using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Onvif.Core.Client.Security {
	public class SoapSecurityHeaderInspector : IClientMessageInspector {
		readonly string username;
		readonly string password;
		readonly TimeSpan time_shift;

		public SoapSecurityHeaderInspector (string username, string password, TimeSpan timeShift)
		{
			this.username = username;
			this.password = password;
			time_shift = timeShift;
		}

		public void AfterReceiveReply (ref Message reply, object correlationState)
		{

		}

		public object BeforeSendRequest (ref Message request, IClientChannel channel)
		{
			request.Headers.Add (new SoapSecurityHeader (username, password, time_shift));

			return null;
		}
	}
}
