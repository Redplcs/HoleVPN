using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using HoleVpn.Client.UI.Domain.Implementation;
using HoleVpn.Client.UI.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HoleVpn.Client.UI.Main;

public partial class App : Application
{
    private readonly IServiceProvider _services;

    public App()
    {
        Name = "HoleVPN";

        _services = CreateServiceProvider();
    }

    private ServiceProvider CreateServiceProvider()
    {
        var services = new ServiceCollection();

        services.AddSingleton<IConnectionProvider, DummyConnectionProvider>();

        services.AddSingleton(this);
        services.AddSingleton<MainWindow>();

        return services.BuildServiceProvider();
    }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = _services.GetRequiredService<MainWindow>();
            desktop.MainWindow.Title = Name;
        }

        base.OnFrameworkInitializationCompleted();
    }
}