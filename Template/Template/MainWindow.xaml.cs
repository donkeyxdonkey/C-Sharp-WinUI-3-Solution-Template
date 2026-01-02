using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Template;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        TextBlock b = new()
        {
            Text = Hello.ItsMe,
        };

        Content = b;
    }
}
