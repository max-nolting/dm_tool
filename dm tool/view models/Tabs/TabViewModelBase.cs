
namespace dm_tool.view_models.Tabs;

public abstract class TabViewModelBase(string name) : ViewModelBase
{
    private string _name = name;
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            RaisePropertyChanged();
        }
    }
}
