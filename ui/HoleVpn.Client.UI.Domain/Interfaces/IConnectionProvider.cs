using HoleVpn.Client.UI.Domain.ValueObjects;
using System.Net;

namespace HoleVpn.Client.UI.Domain.Interfaces;

public interface IConnectionProvider
{
    ValueTask<bool> ConnectAsync(EndPoint endpoint, CancellationToken cancellationToken);

    ConnectionState GetConnectionState();
}
