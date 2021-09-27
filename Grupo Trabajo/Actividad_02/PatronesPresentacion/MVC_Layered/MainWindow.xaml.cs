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
using System.Windows.Shapes;
using MVC_Layered.UI;
using MVC_Layered.Business;

namespace MVC_Layered
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IActividadesController _controlador;
        public MainWindow()
        {
            InitializeComponent();
            _controlador = new ActividadesController (new ActividadesModel());
        }

        private void ActividadesButton_Click(object sender, RoutedEventArgs e)
        {
            _controlador.MostrarActividadesView(this);
        }
    }
}
