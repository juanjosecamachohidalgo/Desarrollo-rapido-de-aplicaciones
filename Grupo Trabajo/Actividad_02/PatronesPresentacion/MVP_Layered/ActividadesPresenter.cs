using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CosteActividades;
using CosteActividades.ServicioDatos;
using System.Windows;
using System.Windows.Media;
using MVP_Layered.Business;

namespace MVP_Layered.UI
{
    
    public class ActividadesPresenter 
    {
        private readonly IActividadesModel _modelo;
        private readonly IActividadesView _vista;
        public ActividadesPresenter(IActividadesView actividadView, IActividadesModel actividadModel)
        {
            if (actividadModel == null)
                throw new ArgumentNullException("actividadModel");
            if (actividadView == null)
                throw new ArgumentNullException("actividadView");
            _modelo = actividadModel;
            _modelo.ActividadActualizada += Modelo_ActividadActualizada;
            _vista = actividadView;
            _vista.DetallesActualizados += Vista_DetallesActualizados;
            _vista.ActividadActualizada += Vista_ActividadActualizada;
            _vista.ActividadSelectionChanged += Vista_ActividadSelectionChanged;
            _vista.CargarActividades(_modelo.ObtenerActividades());
        }

        void Modelo_ActividadActualizada(object sender, ActividadEventArgs e)
        {
            _vista.ActualizarActividad(e.Actividad);
        }

        void Vista_ActividadSelectionChanged(object sender, EventArgs e)
        {
            int Id = _vista.IdActividadSeleccionada; 
            if (Id > _vista.SIN_SELECCION)
            {
                Actividad actividad = _modelo.ObtenerActividad(Id);
                _vista.HabilitarControles(true);
                _vista.ActualizarDetalles(actividad);
                ActualizarColorPrecioEstimado(actividad);
            }
            else
            {
                _vista.HabilitarControles(false);
            }
        }

        void Vista_ActividadActualizada(object sender, ActividadEventArgs e)
        {
            _modelo.ActualizarActividad(e.Actividad);
            ActualizarColorPrecioEstimado(e.Actividad);
        }

        void Vista_DetallesActualizados(object sender, ActividadEventArgs e)
        {
            ActualizarColorPrecioEstimado(e.Actividad);
        }

        private void ActualizarColorPrecioEstimado(Actividad actividad)
        {
            if (actividad.Id == _vista.IdActividadSeleccionada)
            {
                if (actividad.PrecioActual <= 0)
                {
                    _vista.PonerColorPrecioEstimado(null);
                }
                else if (actividad.PrecioActual > actividad.PrecioEstimado)
                {
                    _vista.PonerColorPrecioEstimado(Colors.Red);
                }
                else
                {
                    _vista.PonerColorPrecioEstimado(Colors.Green);
                }
            }
        }
    }

}
