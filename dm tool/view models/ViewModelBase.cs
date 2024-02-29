using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace dm_tool.view_models;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}