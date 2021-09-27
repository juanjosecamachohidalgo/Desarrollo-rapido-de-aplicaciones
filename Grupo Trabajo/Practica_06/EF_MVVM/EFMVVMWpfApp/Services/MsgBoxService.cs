using System.Windows;

namespace EFMVVMWpfApp.Services
{
    public class MsgBoxService : IMsgBoxService
    {
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon);
        }
    }
}
