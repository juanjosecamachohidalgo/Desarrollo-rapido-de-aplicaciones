using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosteActividades;
using CosteActividades.ServicioDatos;

namespace MVC_Layered.Business
{

    public class ActividadEventArgs : EventArgs
    {
        public Actividad Actividad { get; set; }
        public ActividadEventArgs(Actividad actividad)
        {
            Actividad = actividad;
        }
    }

    public interface IActividadesModel
    {
        IEnumerable<IActividad> Actividades { get; set; }
        void ActualizarActividad(Actividad actividad);
        event EventHandler<ActividadEventArgs> ActividadActualizada;
    }
    public class ActividadesModel : IActividadesModel
    {
        public IEnumerable<IActividad> Actividades { get; set; }
        public event EventHandler<ActividadEventArgs> ActividadActualizada = delegate { };
        public ActividadesModel()
        {
            Actividades = new ServicioDatos().ObtenerListaActividades();
        }
        private void OnActividadActualizada(Actividad actividad)
        {
            ActividadActualizada(this, new ActividadEventArgs(actividad));
        }
        public void ActualizarActividad(Actividad actividad)
        {
            Actividad actividadSeleccionada = Actividades.Where(p => p.Id == actividad.Id).FirstOrDefault() as Actividad;
            actividadSeleccionada.Nombre = actividad.Nombre;
            actividadSeleccionada.PrecioEstimado = actividad.PrecioEstimado;
            actividadSeleccionada.PrecioActual = actividad.PrecioActual;
            OnActividadActualizada(actividadSeleccionada);
        }
    }

}

    
