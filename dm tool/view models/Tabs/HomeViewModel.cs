
using DmTool.Core;
using DmTool.Services;
using DmTool.ViewModels.Tabs;

namespace DmTool.ViewModels.Tabs;

public class HomeViewModel : TabViewModelBase
{
    public RelayCommand NavigateToSettingsCommand { get; set; }

    public HomeViewModel(INavigationService nav) : base("Home", nav)
    {
        NavigateToSettingsCommand = new((o) => Navigation.NavigateTo<SettingsViewModel>());
    }
}
