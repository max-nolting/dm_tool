
using DmTool.Core;
using DmTool.Services;

namespace DmTool.ViewModels.Tabs;

public abstract class TabViewModelBase : ViewModel
{
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged();
        }
    }
    private INavigationService _navigation;
    public INavigationService Navigation
    {
        get => _navigation; set
        {
            _navigation = value;
            OnPropertyChanged();
        }
    }

    public TabViewModelBase(string name, INavigationService navigation)
    {
        Name = name;
        Navigation = navigation;
    }
}
