using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MVCPasivoClassLibrary;

namespace MVCWpfApplication
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

            MainWindow vista = new MainWindow();

            Controlador controlador = new Controlador(modelo, (IVista)vista);

            vista.Show();
        }
    }
}
