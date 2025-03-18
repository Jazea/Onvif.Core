using Onvif.Core.Discovery.Common;
using Onvif.Core.Discovery.Interfaces;
using Onvif.Core.Discovery.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Onvif.Core.Discovery;

public class DiscoveryService : IDiscoveryService
{
    readonly IWSDiscovery wsDiscovery;
    CancellationTokenSource cancellation;
    bool isRunning;

    public DiscoveryService()
    {
        DiscoveredDevices = [];
        wsDiscovery = new WSDiscovery();
    }

    public ObservableCollection<DiscoveryDevice> DiscoveredDevices { get; }

    public async Task Start()
    {
        await Start(Constants.WS_TIMEOUT, new UdpClientWrapper());
    }
    public async Task Start(int port)
    {
        await Start(Constants.WS_TIMEOUT, new UdpClientWrapper(port));
    }

    public async Task Start(int timeout, int port)
    {
        await Start(timeout, new UdpClientWrapper(port));
    }

    public async Task Start(string ipAddress, int port)
    {
        await Start(Constants.WS_TIMEOUT, new UdpClientWrapper(ipAddress, port));
    }

    public async Task Start(int timeout, string ipAddress, int port)
    {
        await Start(timeout, new UdpClientWrapper(ipAddress, port));
    }

    public async Task Start(int timeout, IUdpClient client,
      CancellationToken cancellationToken = default)
    {
        if (isRunning)
        {
            throw new InvalidOperationException("The discovery is already running");
        }
        isRunning = true;
        cancellation = new CancellationTokenSource();
        try
        {
            while (isRunning)
            {
                var devicesDiscovered = await wsDiscovery.Discover(timeout, client, cancellationToken).ConfigureAwait(false);
                SyncDiscoveryDevices(devicesDiscovered);
            }
        }
        catch (OperationCanceledException)
        {
            isRunning = false;
        }
    }

    public void Stop()
    {
        isRunning = false;
        cancellation?.Cancel();
    }

    void SyncDiscoveryDevices(IEnumerable<DiscoveryDevice> syncDevices)
    {
        var lostDevices = new List<DiscoveryDevice>(DiscoveredDevices.Except(syncDevices));
        foreach (var lostDevice in lostDevices)
        {
            DiscoveredDevices.Remove(lostDevice);
        }
        var newDevices = new List<DiscoveryDevice>(syncDevices.Except(DiscoveredDevices));
        foreach (var newDevice in newDevices)
        {
            DiscoveredDevices.Add(newDevice);
        }
    }
}
