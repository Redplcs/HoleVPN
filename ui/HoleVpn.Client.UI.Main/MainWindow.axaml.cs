using Avalonia.Controls;
using Avalonia.Interactivity;
using HoleVpn.Client.UI.Domain.Interfaces;
using System.Threading;

namespace HoleVpn.Client.UI.Main;

public partial class MainWindow : Window
{
    private readonly IConnectionProvider _connection;

    public MainWindow(IConnectionProvider connection)
    {
        InitializeComponent();

        _connection = connection;
    }

    private void OnConnectButtonClicked(object? sender, RoutedEventArgs e)
    {
        _connection.ConnectAsync(null!, CancellationToken.None).GetAwaiter().GetResult();
    }
}