using System.Windows;
using MVCPasivoClassLibrary;

namespace MVCWpfApplication
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IVista
    {
        private Controlador _controlador;
        public MainWindow()
        {
            InitializeComponent();
        }

        public Controlador Controlador
        {
            get
            {
                return _controlador;
            }
            set
            {
                _controlador = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return CantidadTextBox.Text;
            }
            set
            {
                CambioLabel.Content = value;
            }
        }

        public string MensajeCambio
        {
            get
            {
                return CambioLabel.Content.ToString();
            }
            set
            {
                CambioLabel.Content = "Son " + value;
            }
        }

        public string MensajeIntro
        {
            get
            {
                return IntroLabel.Content.ToString();
            }
            set
            {
                IntroLabel.Content = "¿Que cantidad desea introducir?";
            }
        }

        private void PesetasButton_Click(object sender, RoutedEventArgs e)
        {
            _controlador.ConvertirCantidadAPesetas(Cantidad);
        }

        private void eurosButton_Click(object sender, RoutedEventArgs e)
        {
            _controlador.ConvertirCantidadAEuros(Cantidad);
        }
    }
}
