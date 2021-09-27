using System.Windows;

namespace EFMVVMWpfApp.Services
{
    public interface IMsgBoxService
    {
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);
    }
}
