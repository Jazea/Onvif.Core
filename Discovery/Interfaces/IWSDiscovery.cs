using Onvif.Core.Discovery.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Onvif.Core.Discovery.Interfaces
{
	public interface IWSDiscovery
	{
		Task<IEnumerable<DiscoveryDevice>> Discover (int Timeout,
			CancellationToken cancellationToken = default(CancellationToken));
		Task<IEnumerable<DiscoveryDevice>> Discover (int Timeout, IUdpClient client,
			CancellationToken cancellationToken = default (CancellationToken));
	}
}
