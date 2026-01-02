using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.Windows.ApplicationModel.DynamicDependency;
using System;
using System.Threading;

namespace Template;

internal class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        _ = args;

        Bootstrap.Initialize(0x00010008);

        try
        {
            Application.Start((param) =>
            {
                DispatcherQueueSynchronizationContext context = new(DispatcherQueue.GetForCurrentThread());
                SynchronizationContext.SetSynchronizationContext(context);
                _ = new App();
            });
        }
        finally
        {
            Bootstrap.Shutdown();
        }
    }
}
