using DmTool.ViewModels.Tabs;
using DmTool.views;
using DmTool.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using DmTool.Core;
using DmTool.Services;

namespace DmTool;

public partial class App : Application
{
    public static IHost? AppHost { get; private set; }

    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<MainWindow>(provider => new views.MainWindow
                {
                    DataContext = provider.GetRequiredService<MainViewModel>()
                }) ;

                services.AddSingleton<MainViewModel>();
                services.AddSingleton<HomeViewModel>();
                services.AddSingleton<NPCGeneratorViewModel>();
                services.AddSingleton<SettingsViewModel>();

                services.AddSingleton<INavigationService, NavigationService>();
                services.AddSingleton<Func<Type, ViewModel>>(provider => viewModelType => (ViewModel)provider.GetRequiredService(viewModelType));

                //services.AddSingleton<TabHandler>();

                //services.AddSingleton<MainViewModel>();

                //services.AddSingleton<NPCGeneratorViewModel>();

                //services.AddSingleton<NPCGeneratorViewModel>();
                //services.AddSingleton<InitiativeTabViewModel>();
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();
        
        var mainWindow = AppHost.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();
        base.OnExit(e);
    }
}
