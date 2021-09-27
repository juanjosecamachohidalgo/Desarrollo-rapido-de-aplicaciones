using System;
using System.Windows.Input;

namespace MVVMBasicoWpfApp.ViewModels
{
    public class RelayCommand : ICommand
    {
        public Predicate<object> CanExecuteDelegate;
        public Action<object> ExecuteDelegate;
 
        public bool CanExecute(object parameter)
        {
            return CanExecuteDelegate(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            ExecuteDelegate(parameter);
        }
    }
}
