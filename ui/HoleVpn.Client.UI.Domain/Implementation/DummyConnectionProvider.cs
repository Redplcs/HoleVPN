using HoleVpn.Client.UI.Domain.Interfaces;
using HoleVpn.Client.UI.Domain.ValueObjects;
using System.Net;

namespace HoleVpn.Client.UI.Domain.Implementation;

public sealed class DummyConnectionProvider : IConnectionProvider
{
    public ValueTask<bool> ConnectAsync(EndPoint endpoint, CancellationToken cancellationToken)
    {
        return ValueTask.FromResult(false);
    }

    public ConnectionState GetConnectionState()
    {
        return ConnectionState.None;
    }
}
