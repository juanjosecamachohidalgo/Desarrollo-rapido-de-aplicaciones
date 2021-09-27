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
using MVP_Layered.Business;
using MVP_Layered.UI;
using CosteActividades.ServicioDatos;
using CosteActividades;

namespace MVP_Layered.UI
{

    public interface IActividadesView
    {
        int SIN_SELECCION {get;}
        int IdActividadSeleccionada { get; }
        void ActualizarActividad(Actividad actividad);
        void CargarActividades(IEnumerable<Actividad> actividades);
        void ActualizarDetalles(Actividad actividad);
        void HabilitarControles(bool isEnabled);
        void PonerColorPrecioEstimado(Color? color);

        event EventHandler<ActividadEventArgs> ActividadActualizada;

        event EventHandler<ActividadEventArgs> DetallesActualizados;
        event EventHandler ActividadSelectionChanged;
    }




    public partial class ActividadesView : IActividadesView
    {          
        public ActividadesView()
        {
            InitializeComponent();
            IdActividadSeleccionada = SIN_SELECCION;
        }

        public void ActualizarActividad(Actividad actividad)
        {
            IEnumerable<Actividad> actividades = ActividadesComboBox.ItemsSource as IEnumerable<Actividad>;
            Actividad actividadActualizar = actividades.Where(p => p.Id == actividad.Id).First();
            //actividadActualizar.Nombre = actividad.Nombre;
            actividadActualizar.PrecioEstimado = actividad.PrecioEstimado;
            actividadActualizar.PrecioActual = actividad.PrecioActual;
            if (actividad.Id == IdActividadSeleccionada) ActualizarDetalles(actividad);             
        }

        public int SIN_SELECCION
        {
            get { return -1; }
        }
        public int IdActividadSeleccionada { get; private set; }

        public void CargarActividades(IEnumerable<Actividad> actividades)
        {
            ActividadesComboBox.ItemsSource = actividades;
            ActividadesComboBox.DisplayMemberPath = "Nombre";
            ActividadesComboBox.SelectedValuePath = "Id";
        }

        public void ActualizarDetalles(Actividad actividad)
        {
            PrecioEstimadoTextBox.Text = actividad.PrecioEstimado.ToString();
            PrecioActualTextBox.Text = actividad.PrecioActual.ToString();
            DetallesActualizados(this, new ActividadEventArgs(actividad));
        }

        public void HabilitarControles(bool isEnabled)
        {
            PrecioEstimadoTextBox.IsEnabled = isEnabled;
            PrecioActualTextBox.IsEnabled = isEnabled;
            ActualizarButton.IsEnabled = isEnabled;
        }

        public void PonerColorPrecioEstimado(Color? color)
        {
            PrecioEstimadoTextBox.Foreground = (color == null) ? PrecioActualTextBox.Foreground : new SolidColorBrush((Color)color);
        }

        public event EventHandler<ActividadEventArgs> DetallesActualizados = delegate { };
        public event EventHandler<ActividadEventArgs> ActividadActualizada = delegate { };
        public event EventHandler ActividadSelectionChanged = delegate { };

        private void ActividadesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IdActividadSeleccionada = (ActividadesComboBox.SelectedValue == null) ? SIN_SELECCION :
                int.Parse(ActividadesComboBox.SelectedValue.ToString());
            ActividadSelectionChanged(this, new EventArgs());
        }

        private void ActualizarButton_Click(object sender, RoutedEventArgs e)
        {
            Actividad actividad = new Actividad();
            actividad.PrecioEstimado = GetDouble(PrecioEstimadoTextBox.Text);
            actividad.PrecioActual = GetDouble(PrecioActualTextBox.Text);
            actividad.Id = int.Parse(ActividadesComboBox.SelectedValue.ToString());
           // actividad.Nombre = ActividadesComboBox.Text;
            ActividadActualizada(this, new ActividadEventArgs(actividad));
        }

        private double GetDouble(string text)
        {
            return string.IsNullOrEmpty(text) ? 0 : double.Parse(text);
        }



    }
}
