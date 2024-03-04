
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
    public RelayCommand NavigateToHomeCommand { get; set; }
    public RelayCommand NavigateToSettingsCommand { get; set; }
    public RelayCommand NavigateToNpcGeneratorCommand { get; set; }

    public MainViewModel(INavigationService navService) 
    { 
        Navigation = navService;
        NavigateToHomeCommand = new RelayCommand((o) => Navigation.NavigateTo<HomeViewModel>());
        NavigateToSettingsCommand = new RelayCommand((o) => Navigation.NavigateTo<SettingsViewModel>());
        NavigateToNpcGeneratorCommand = new RelayCommand((o)=>Navigation.NavigateTo<NPCGeneratorViewModel>());
    }
}