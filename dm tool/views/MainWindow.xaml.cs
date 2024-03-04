using DmTool.view_models;
using DmTool.views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;


namespace DmTool;

public partial class MainWindow : Window
{
    private NPCGenerator npcGenerator;

    public MainWindow(IServiceProvider serviceProvider)
    {
        npcGenerator = serviceProvider.GetRequiredService<NPCGenerator>();
        DataContext = serviceProvider.GetRequiredService<MainViewModel>();
        InitializeComponent();
    }
}