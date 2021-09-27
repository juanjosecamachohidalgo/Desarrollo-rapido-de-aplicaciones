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

namespace MVVM_Layered.App
{

    public interface IActividadViewModel : IActividad
    {
        Estado DetallesEstadoPrecioEstimado { get; set; }
    }
    public enum Estado { Ninguno, Bien, Mal }


    public class ActividadViewModel : IActividadViewModel, INotifyPropertyChanged
    {
        private int _Id;
        private string _nombre;
        private double _precioEstimado;
        private double _precioActual;
        private Estado _estadoPrecioEstimado = Estado.Ninguno;

        public ActividadViewModel()
        {}
        public ActividadViewModel(IActividad actividad)
        {
            if (actividad == null)  return;
            Id = actividad.Id;
            Actualizar(actividad);
        }
        public void Actualizar(IActividad actividad)
        {
            Id = actividad.Id;
            Nombre = actividad.Nombre;
            PrecioEstimado = actividad.PrecioEstimado;
            PrecioActual = actividad.PrecioActual;
        }
        private void ActualizarEstadoPrecioEstimado()
        {
            if (PrecioActual == 0)
                DetallesEstadoPrecioEstimado = Estado.Ninguno;
            else if (PrecioActual <= PrecioEstimado)
                DetallesEstadoPrecioEstimado = Estado.Bien;
            else
                DetallesEstadoPrecioEstimado = Estado.Mal;
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; NotifyPropertyChanged("Id"); }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; NotifyPropertyChanged("Nombre"); }
        }
        public double PrecioEstimado
        {
            get { return _precioEstimado; }
            set
            {
                _precioEstimado = value;
                NotifyPropertyChanged("PrecioEstimado");
            }
        }
        public double PrecioActual
        {
            get { return _precioActual; }
            set
            {
                _precioActual = value;
                ActualizarEstadoPrecioEstimado();
                NotifyPropertyChanged("PrecioActual");
            }
        }
        public Estado DetallesEstadoPrecioEstimado
        {
            get { return _estadoPrecioEstimado; }
            set
            {
                _estadoPrecioEstimado = value;
                NotifyPropertyChanged("DetallesEstadoPrecioEstimado");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        protected void NotifyPropertyChanged(string nombrePropiedad)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
        }
    }
}
