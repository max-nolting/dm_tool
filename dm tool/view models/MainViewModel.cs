
using DmTool.view_models.Tabs;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;

namespace DmTool.view_models;

public class MainViewModel(IServiceProvider serviceProvider)
{
    public ObservableCollection<ViewModelBase>? OpenTabs { get; private set; } = 
        [serviceProvider.GetRequiredService<NPCGeneratorViewModel>(), 
        serviceProvider.GetRequiredService<InitiativeTabViewModel>()];
}