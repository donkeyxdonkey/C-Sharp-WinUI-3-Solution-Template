using Microsoft.UI.Xaml;

namespace Template;

public partial class App : Application
{
    private Window? _window;

    public App()
    {
        InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        _ = args;

        _window = new MainWindow();
        _window.Activate();
    }
}
