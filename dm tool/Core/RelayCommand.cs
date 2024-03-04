
using System.Windows.Input;

namespace DmTool.Core;

public class RelayCommand(Action<object?> exe, Predicate<object?> canExe) : ICommand
{
    protected Predicate<object?> canExecute = canExe;
    readonly Action<object?> execute = exe;

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter) => canExecute?.Invoke(parameter) ?? true;

    public void Execute(object? parameter) => execute?.Invoke(parameter);

    public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

    public RelayCommand(Action<object?> execute) : this(execute, (o) => true) { }
}
