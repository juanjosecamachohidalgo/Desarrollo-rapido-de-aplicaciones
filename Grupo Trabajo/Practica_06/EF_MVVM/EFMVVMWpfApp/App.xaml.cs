using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using EFMVVMWpfApp.Services;

namespace EFMVVMWpfApp
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
