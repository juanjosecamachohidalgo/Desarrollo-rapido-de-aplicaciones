using System.Windows;
using System.Windows.Input;

namespace MVVMBasicoWpfApp.Services
{
    public interface IMsgBoxService
    {
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);
    }
}
