﻿
using dm_tool.view_models.Tabs;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;

namespace dm_tool.view_models;

public class MainViewModel(IServiceProvider serviceProvider)
{
    public ObservableCollection<ViewModelBase>? OpenTabs { get; private set; } = 
        [serviceProvider.GetRequiredService<NPCTabViewModel>(), 
        serviceProvider.GetRequiredService<InitiativeTabViewModel>()];
}