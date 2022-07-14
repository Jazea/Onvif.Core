using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Onvif.Core.Discovery.Models
{
	public class DiscoveryDevice
	{
		public IEnumerable<string> Types { get; internal set; }
		public IEnumerable<string> XAdresses { get; internal set; }
		public string Model { get; internal set; }
		public string Name { get; internal set; }
		public IPAddress Address { get; internal set; }

		public override bool Equals (object obj)
		{
			var o = obj as DiscoveryDevice;
			if (o == null) {
				return false;
			}
			if (o.Model != Model || o.Name != Name || o.Address != Address
				|| o.Types.Count() != Types.Count() || o.XAdresses.Count() != XAdresses.Count()) {
				return false;
			}
			for (var i = 0; i < Types.Count(); i++) {
				if (!Types.ElementAt(i).Equals (o.Types.ElementAt(i))) {
					return false;
				}
			}
			for (var i = 0; i < XAdresses.Count (); i++) {
				if (!XAdresses.ElementAt (i).Equals (o.XAdresses.ElementAt (i))) {
					return false;
				}
			}
			return true;
		}

		public override int GetHashCode ()
		{
			var hash = 1;
			if (Types != null) {
				foreach (var type in Types) {
					hash += type.GetHashCode ();
				}
			}
			if (XAdresses != null) {
				foreach (var address in XAdresses) {
					hash += address.GetHashCode ();
				}
			}
			hash += (Model?.GetHashCode () + Name?.GetHashCode () + Address?.GetHashCode ()) ?? 0;
			return hash;
		}
	}
}
