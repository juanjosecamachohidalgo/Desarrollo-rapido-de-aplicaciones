using EFMVVMWpfApp.Services;
using eLearningWebAPIClientMVVMWpfApp.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace eLearningWebAPIClientMVVMWpfApp
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
