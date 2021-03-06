using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SaludoMVVMWpfApplication
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IModelo modelo = new Modelo();
            var viewModel = new HolaViewModel(modelo);
            HolaView window = new HolaView();
            window.DataContext = viewModel;
            window.Show();
        }

    }
}
