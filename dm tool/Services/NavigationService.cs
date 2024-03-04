
using DmTool.Core;

namespace DmTool.Services;

public interface INavigationService
{
     public ViewModel CurrentView { get; }
    void NavigateTo<T>() where T : ViewModel;
}

public class NavigationService : ObservableObject, INavigationService
{
    private ViewModel _currentView;
    private Func<Type, ViewModel> _viewModelFactory;

    public ViewModel CurrentView { get => _currentView; set
        {
            _currentView = value;
            OnPropertyChanged();
        } 
    }

    public NavigationService(Func<Type, ViewModel> viewModelFactory)
    {
        _viewModelFactory = viewModelFactory;
    } 

    public void NavigateTo<T>() where T : ViewModel
    {
        ViewModel viewModel = _viewModelFactory.Invoke(typeof(T));
        CurrentView = viewModel;
    }
}
