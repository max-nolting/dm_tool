
using DmTool.Core;
using DmTool.Services;

namespace DmTool.ViewModels.Tabs;

class SettingsViewModel : TabViewModelBase
{
    public RelayCommand NavigateToHomeCommand { get; set; }

    public SettingsViewModel(INavigationService nav) : base("Settings", nav)
    {
        NavigateToHomeCommand = new((o) => Navigation.NavigateTo<HomeViewModel>());
    }
}