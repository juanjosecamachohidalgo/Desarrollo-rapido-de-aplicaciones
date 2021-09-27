using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SumaMVVMWpfApplication
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var model = new Modelo();
            //model.Num1 = 0;
            //model.Num2 = 0;
            var sumaViewModel = new SumaVM(model);
            SumaView view = new SumaView();
            view.DataContext = sumaViewModel;
            view.Show();
        }

    }
}
