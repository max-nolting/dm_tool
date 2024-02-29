using dm_tool.view_models;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;


namespace dm_tool;

public partial class MainWindow : Window
{
    public MainWindow(IServiceProvider serviceProvider)
    {
        DataContext = serviceProvider.GetService<MainViewModel>();
        InitializeComponent();
    }
}