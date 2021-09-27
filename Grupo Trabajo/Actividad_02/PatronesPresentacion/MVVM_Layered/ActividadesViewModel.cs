using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CosteActividades;
using CosteActividades.ServicioDatos;
using System.Windows;
using System.Windows.Media;
using MVVM_Layered.Business;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVM_Layered.App
{

    internal class ActualizarCommand : ICommand
    {
        private const int SON_IGUALES = 0;
        private const int NINGUNO_SELECCIONADO = -1;
        private IActividadesViewModel _vm;
        public ActualizarCommand(IActividadesViewModel viewModel)
        {
            _vm = viewModel;
            _vm.PropertyChanged += vm_PropertyChanged;
        }
        private void vm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Compare(e.PropertyName, ActividadesViewModel.PROPIEDAD_ACTIVIDAD_SELECCIONADA) == SON_IGUALES)
            {
                CanExecuteChanged(this, new EventArgs());
            }
        }
        public bool CanExecute(object parameter)
        {
            if (_vm.ActividadSeleccionada == null) return false;
            return ((ActividadViewModel)_vm.ActividadSeleccionada).Id > NINGUNO_SELECCIONADO;
        }

        public event EventHandler CanExecuteChanged = delegate { };
        public void Execute(object parameter)
        {
            _vm.ActualizarActividad();
        }
    }

    public interface IActividadesViewModel : INotifyPropertyChanged
    {
        IActividadViewModel ActividadSeleccionada { get; set; }
        void ActualizarActividad();
    }

    public class ActividadesViewModel : IActividadesViewModel, INotifyPropertyChanged
    {
        private readonly IActividadesModel _modelo;
        public const string PROPIEDAD_ACTIVIDAD_SELECCIONADA = "ActividadSeleccionada";

        private IActividadViewModel _actividadSelecionada;
        private Estado _estadoDetallesPrecioEstimado = Estado.Ninguno;
        private bool _detallesHabilitados;

        private readonly ICommand _actualizarCommand;

        public ObservableCollection<Actividad> Actividades { get { return _modelo.Actividades; } }
        public int? ValorSeleccionado
        {
            set
            {
                if (value == null) return;
                Actividad actividad = ObtenerActividad((int)value);
                if (ActividadSeleccionada == null)
                {
                    ActividadSeleccionada = new ActividadViewModel(actividad);
                }
                else
                {
                    ActividadSeleccionada.Actualizar(actividad);
                }
                DetallesEstadoPrecioEstimado = ActividadSeleccionada.DetallesEstadoPrecioEstimado;
            }
        }

        public ActividadesViewModel(IActividadesModel actividadModel)
        {
            _modelo = actividadModel;
            _modelo.ActividadActualizada += model_ActividadActualizada;
            _actualizarCommand = new ActualizarCommand(this);
        }
        public IActividadViewModel ActividadSeleccionada
        {
            get { return _actividadSelecionada; }
            set
            {
                if (value == null)
                {
                    _actividadSelecionada = value;
                    DetallesHabilitados = false;
                }
                else
                {
                    if (_actividadSelecionada == null)
                    {
                        _actividadSelecionada = new ActividadViewModel(value);
                    }
                    _actividadSelecionada.Actualizar(value);
                    DetallesEstadoPrecioEstimado = _actividadSelecionada.DetallesEstadoPrecioEstimado;
                    DetallesHabilitados = true;
                    NotifyPropertyChanged(PROPIEDAD_ACTIVIDAD_SELECCIONADA);
                }
            }
        }
        public Estado DetallesEstadoPrecioEstimado
        {
            get { return _estadoDetallesPrecioEstimado; }
            set
            {
                _estadoDetallesPrecioEstimado = value;
                NotifyPropertyChanged("DetallesEstadoPrecioEstimado");
            }
        }
        public bool DetallesHabilitados
        {
            get { return _detallesHabilitados; }
            set
            {
                _detallesHabilitados = value;
                NotifyPropertyChanged("DetallesHabilitados");
            }
        }
        public ICommand ActualizarCommand
        {
            get { return _actualizarCommand; }
        }

        
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        protected void NotifyPropertyChanged(string nombrePropiedad)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
        }

        public void ActualizarActividad()
        {
            DetallesEstadoPrecioEstimado = ActividadSeleccionada.DetallesEstadoPrecioEstimado;
            _modelo.ActualizarActividad(ActividadSeleccionada);
        }
        private void model_ActividadActualizada(object sender,ActividadEventArgs e)
        {
            ObtenerActividad(e.Actividad.Id).Actualizar(e.Actividad);
            if (ActividadSeleccionada != null  && e.Actividad.Id == ActividadSeleccionada.Id)
            {
                ActividadSeleccionada.Actualizar(e.Actividad);
                DetallesEstadoPrecioEstimado = ActividadSeleccionada.DetallesEstadoPrecioEstimado;
            }
        }
        private Actividad ObtenerActividad(int actividadId)
        {
            return (from p in Actividades
                    where p.Id == actividadId
                    select p).FirstOrDefault();
        }
    }

}
