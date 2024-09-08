using System.Net;

namespace HoleVpn.Client.UI.Domain.ValueObjects;

public record Server
{
    public string Name { get; set; }
    public EndPoint Endpoint { get; set; }
}
