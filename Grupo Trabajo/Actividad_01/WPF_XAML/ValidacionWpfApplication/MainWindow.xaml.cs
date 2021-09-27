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
using WPF.RelayCommand;
using System.Resources;
using System.Globalization;
using System.Threading;

namespace ValidacionWpfApplication
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsuarioViewDataModel _viewModel;
        public static ResourceManager ResGlobal;
        public MainWindow()
        {
            //CultureInfo ci = new CultureInfo("es-ES");
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            InitializeComponent();

            ResGlobal = new ResourceManager("ValidacionWpfApplication.Resources.MensajesErrorResources", typeof(App).Assembly);

            _viewModel = new UsuarioViewDataModel();
            DataContext = _viewModel;
            _viewModel.OkCommand = new RelayCommand(Action, Predicate);
        }

        private void Action(object param)
        {
            //MessageBox.Show("hola chaval");
            string hello = ResGlobal.GetString("HolaMensaje");
            MessageBox.Show(hello);

        }

        private bool Predicate(object param)
        {
            if (!_viewModel.ValidateObject()) return false;
            if (_viewModel.HasErrors) return false;
            else return true;
        }
    }
}
