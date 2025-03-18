using Onvif.Core.Discovery.Models;

using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Onvif.Core.Discovery.Interfaces;

public interface IDiscoveryService
{
    ObservableCollection<DiscoveryDevice> DiscoveredDevices { get; }
    Task Start();
    Task Start(int port);
    Task Start(int timeout, int port);
    Task Start(string ipAddress, int port);
    Task Start(int timeout, string ipAddress, int port);
    Task Start(int timeout, IUdpClient client,
                CancellationToken cancellationToken = default);
    void Stop();
}
