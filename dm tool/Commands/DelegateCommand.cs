
using System.Windows.Input;

namespace dm_tool.Commands;

internal class DelegateCommand(Action<object?> exe, Predicate<object?> canExe) : ICommand
{
    protected Predicate<object?> canExecute = canExe;
    readonly Action<object?> execute = exe;

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter) => canExecute?.Invoke(parameter) ?? true;

    public void Execute(object? parameter) => execute?.Invoke(parameter);

    public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

    public DelegateCommand(Action<object?> execute) : this(execute, (o) => true) { }
}
