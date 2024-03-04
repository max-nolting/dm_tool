using dm_tool.view_models;
using dm_tool.views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;


namespace dm_tool;

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