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

using CosteActividades.ServicioDatos;
using CosteActividades;

namespace MonoliticoWPFApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource actividadViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("actividadViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            actividadViewSource.Source = new ServicioDatos().ObtenerListaActividades();
        }

        void actualizarButton_Click(object sender, EventArgs e)
        {
            Actividad actividadSeleccionada = this.nombreComboBox.SelectedItem as Actividad;
            if (actividadSeleccionada != null)
            {
                actividadSeleccionada.PrecioEstimado = double.Parse(precioEstimadoLabel.Content.ToString());
                if (!string.IsNullOrEmpty(precioActualTextBox.Text))
                {
                    actividadSeleccionada.PrecioActual = double.Parse(precioActualTextBox.Text);
                }
                PonerColor(actividadSeleccionada);
            }
        }
        private void nombreComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedIndex > -1)
            {
                MostrarDetalles();
            }
            else
            {
                OcultarDetalles();
            }
        }
        private void PonerColor(Actividad actividadSeleccionada)
        {
            if (actividadSeleccionada.PrecioActual < actividadSeleccionada.PrecioEstimado)
                this.precioEstimadoLabel.Foreground = Brushes.Green;
            else
                if (actividadSeleccionada.PrecioActual > actividadSeleccionada.PrecioEstimado)
                    this.precioEstimadoLabel.Foreground = Brushes.Red;
                else
                    this.precioEstimadoLabel.Foreground = Brushes.Black;

        }



        private void OcultarDetalles()
        {
            precioEstimadoLabel.IsEnabled = false;
            precioActualTextBox.IsEnabled = false;
            actualizarButton.IsEnabled = false;
        }

        private void MostrarDetalles()
        {
            Actividad actividadSeleccionada = this.nombreComboBox.SelectedItem as Actividad;
            precioEstimadoLabel.IsEnabled = true;
            precioEstimadoLabel.Content = actividadSeleccionada.PrecioEstimado.ToString();
            precioActualTextBox.IsEnabled = true;
            precioActualTextBox.Text = (actividadSeleccionada.PrecioActual == 0) ? "" : actividadSeleccionada.PrecioActual.ToString();
            PonerColor(actividadSeleccionada);
            actualizarButton.IsEnabled = true;
        }
    }

}
