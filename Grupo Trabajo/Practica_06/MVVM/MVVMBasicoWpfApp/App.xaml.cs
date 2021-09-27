using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MVVMBasicoWpfApp.Services;

namespace MVVMBasicoWpfApp
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ServiceLocator.Instance.Register<IMsgBoxService>(new MsgBoxService());
        }
    }
}
