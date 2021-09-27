using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVVM_Layered.App;
using MVVM_Layered.Business;
using CosteActividades.ServicioDatos;

namespace MVVM_Layered.UI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IActividadesModel _actividadModel;
        public MainWindow()
        {
            InitializeComponent();
            _actividadModel = new ActividadesModel(new ServicioDatos());
        }

        private void MostrarActividadesButton_Click(object sender, RoutedEventArgs e)
        {
            ActividadesView view = new ActividadesView();
            view.DataContext = new ActividadesViewModel(_actividadModel);
            view.Owner = this;
            view.Show();
        }
    }
}
