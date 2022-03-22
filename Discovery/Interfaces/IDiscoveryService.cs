
using Onvif.Core.Discovery.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Onvif.Core.Discovery.Interfaces
{
	public interface IDiscoveryService
	{
		ObservableCollection<DiscoveryDevice> DiscoveredDevices { get; }
		Task Start ();
		void Stop ();
	}
}
