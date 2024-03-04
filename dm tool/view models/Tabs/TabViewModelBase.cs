
using DmTool.Core;

namespace DmTool.ViewModels.Tabs;

public abstract class TabViewModelBase(string name) : ViewModel
{
    private string _name = name;
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged();
        }
    }
}
