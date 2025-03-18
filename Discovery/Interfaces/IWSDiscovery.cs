using Onvif.Core.Discovery.Models;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Onvif.Core.Discovery.Interfaces;

public interface IWSDiscovery
{
    Task<IEnumerable<DiscoveryDevice>> Discover(int timeout,
      CancellationToken cancellationToken = default);
    Task<IEnumerable<DiscoveryDevice>> Discover(int timeout, string ipAddress, int port,
        CancellationToken cancellationToken = default);
    Task<IEnumerable<DiscoveryDevice>> Discover(int timeout, int port,
       CancellationToken cancellationToken = default);
    Task<IEnumerable<DiscoveryDevice>> Discover(int timeout, IUdpClient client,
        CancellationToken cancellationToken = default);
}
