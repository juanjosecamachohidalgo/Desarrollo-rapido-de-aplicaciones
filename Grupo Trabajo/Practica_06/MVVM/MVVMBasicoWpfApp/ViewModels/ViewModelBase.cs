using System;
using System.ComponentModel;
using MVVMBasicoWpfApp.Services;

namespace MVVMBasicoWpfApp.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private ServiceLocator serviceLocator = ServiceLocator.Instance;

        public ServiceLocator ServiceLocator
        {
            get
            {
                return this.serviceLocator;
            }
        }

        public T GetService<T>()
        {
            return this.serviceLocator.Resolve<T>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
