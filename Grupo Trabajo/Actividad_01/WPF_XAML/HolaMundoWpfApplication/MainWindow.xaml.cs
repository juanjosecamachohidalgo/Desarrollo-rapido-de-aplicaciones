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

namespace HolaMundoWpfApplication
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closed += MainWindow_Closed;
        }

        void MainWindow_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CambiarPalabraDePasoUsuarioMenu_Click(object sender, RoutedEventArgs e)
        {
            CambiarPalabraPaso cambiarPalabraPaso = new CambiarPalabraPaso();
            cambiarPalabraPaso.ShowDialog();
        }

        private void AcercaDeUsuarioMenu_Click(object sender, RoutedEventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }

        private void DatosUsuarioMenu_Click(object sender, RoutedEventArgs e)
        {
            Datos datos = new Datos();
            datos.ShowDialog();
        }

        private void ListaUsuariosMenu_Click(object sender, RoutedEventArgs e)
        {
            ListaUsuarios listaUsuarios = new ListaUsuarios();
            listaUsuarios.ShowDialog();
        }

        private void SalirMenu_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ColeccionUsuariosMenu_Click(object sender, RoutedEventArgs e)
        {
            ColeccionUsuarios coleccionUsuarios = new ColeccionUsuarios();
            coleccionUsuarios.ShowDialog();
        }

    }

}
