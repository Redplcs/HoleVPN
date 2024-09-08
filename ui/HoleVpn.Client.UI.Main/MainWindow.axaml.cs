using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace HoleVpn.Client.UI.Main;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnConnectButtonClicked(object? sender, RoutedEventArgs e)
    {
        Debug.WriteLine("Button clicked");
    }
}