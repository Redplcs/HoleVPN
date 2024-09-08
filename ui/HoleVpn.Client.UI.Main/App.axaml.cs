using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace HoleVpn.Client.UI.Main;

public partial class App : Application
{
    public App()
    {
        Name = "HoleVPN";
    }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow()
            {
                Title = Name,
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}