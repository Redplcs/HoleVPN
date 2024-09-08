using HoleVpn.Client.UI.Domain.ValueObjects;
using System.Collections.ObjectModel;
using System.Net;

namespace HoleVpn.Client.UI.Main.ViewModels;

public sealed class MainWindowViewModel : ViewModel
{
    public MainWindowViewModel()
    {
        AvailableServers =
        [
            // Stub entities
            new()
            {
                Name = "Redplcs' HomeServer",
                Endpoint = new DnsEndPoint("redplcs.ddns.net", 22),
            }
        ];
    }

    public ObservableCollection<Server> AvailableServers { get; set; }
}
