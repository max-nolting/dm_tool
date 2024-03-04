
using DmTool.Core;
using DmTool.Services;
using DmTool.ViewModels.Tabs;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;

namespace DmTool.ViewModels;

public class MainViewModel : ViewModel
{
    private INavigationService _navigation;
    public INavigationService Navigation { get => _navigation; set
        {
            _navigation = value;
            OnPropertyChanged();
        } }
    public RelayCommand NavigateHomeCommand { get; set; }
    public RelayCommand NavigateSettingsCommand { get; set; }

    public MainViewModel(INavigationService navService) 
    { 
        Navigation = navService;
        NavigateHomeCommand = new RelayCommand((o) => Navigation.NavigateTo<HomeViewModel>());
        NavigateSettingsCommand = new RelayCommand((o) => Navigation.NavigateTo<SettingsViewModel>());
    }
}