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
using MVC_Layered.Business;
using MVC_Layered.UI;
using CosteActividades.ServicioDatos;
using CosteActividades;

namespace MVC_Layered.UI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class ActividadesView : Window
    {
        private readonly IActividadesModel _modelo;
        private readonly IActividadesController _controlador  = null;
        private const int SIN_SELECCION = -1;
        public ActividadesView(IActividadesController actividadesController, IActividadesModel actividadesModel)
        {
            InitializeComponent();
            _controlador = actividadesController;
            _modelo = actividadesModel;
            _modelo.ActividadActualizada  += Modelo_ActividadActualizada;
            ActividadesComboBox.ItemsSource = _modelo.Actividades;
            ActividadesComboBox.DisplayMemberPath   = "Nombre";
            ActividadesComboBox.SelectedValuePath   = "Id";
        }

        private void Modelo_ActividadActualizada(object sender, ActividadEventArgs e)
        {
            int IdActividadSeleccionada = ObtenerIdActividadSeleccionada();
            if (IdActividadSeleccionada > SIN_SELECCION)
            {
                if (IdActividadSeleccionada == e.Actividad.Id)
                {
                    ActualizarDetalles(e.Actividad);
                }
            }
        }

        private void ActividadesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Actividad project = ObtenerActividadSeleccionada();
            if (project != null)
            {
                PrecioEstimadoTextBox.Text  = project.PrecioEstimado.ToString();
                PrecioEstimadoTextBox.IsEnabled = true;
                PrecioActualTextBox.Text  = project.PrecioActual.ToString();
                PrecioActualTextBox.IsEnabled = true;
                ActualizarButton.IsEnabled = true;
                ActualizarColorPrecioEstimado();
            }
        }

        private void ActualizarButton_Click(object sender, RoutedEventArgs e)
        {
            Actividad actividad = new Actividad()
            {
                Id = (int)ActividadesComboBox.SelectedValue,
                Nombre = ActividadesComboBox.Text,
                PrecioEstimado = GetDouble(PrecioEstimadoTextBox.Text),
                PrecioActual = GetDouble(PrecioActualTextBox.Text)
            };
            _controlador.Actualizar(actividad);
        }


        private void ActualizarDetalles(Actividad actividad)
        {
            PrecioEstimadoTextBox.Text = actividad.PrecioEstimado.ToString();
            PrecioActualTextBox.Text = actividad.PrecioActual.ToString();
            ActualizarColorPrecioEstimado();
        }

        private void ActualizarColorPrecioEstimado()
        {
            double actual = GetDouble(PrecioActualTextBox.Text);
            double estimado = GetDouble(PrecioEstimadoTextBox.Text);
            if (actual == 0)
            {
                PrecioEstimadoTextBox.Foreground  = PrecioActualTextBox.Foreground;
            }
            else if (actual > estimado)
            {
                PrecioEstimadoTextBox.Foreground  = Brushes.Red;
            }
            else
            {
                PrecioEstimadoTextBox.Foreground  = Brushes.Green;
            }
        }
        private double GetDouble(string text)
        {
            return string.IsNullOrEmpty(text) ?  0 : double.Parse(text);
        }
        private Actividad ObtenerActividadSeleccionada()
        {
            return ActividadesComboBox.SelectedItem  as Actividad;
        }
        private int ObtenerIdActividadSeleccionada()
        {
            Actividad actividad = ObtenerActividadSeleccionada();
            return (actividad == null) ? SIN_SELECCION : actividad.Id;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _modelo.ActividadActualizada -= Modelo_ActividadActualizada;
        }


    }
}
