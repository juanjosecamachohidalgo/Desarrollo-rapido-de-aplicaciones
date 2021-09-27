using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosteActividades;
using CosteActividades.ServicioDatos;

namespace MVP_Layered.Business
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
        IEnumerable<Actividad> ObtenerActividades();
        void ActualizarActividad(Actividad actividad);
        event EventHandler<ActividadEventArgs> ActividadActualizada;
        Actividad ObtenerActividad(int Id);
    }
    public class ActividadesModel : IActividadesModel
    {
        private IEnumerable<Actividad> _actividades = null;
        public event EventHandler<ActividadEventArgs> ActividadActualizada = delegate { };
        public ActividadesModel()
        {
            _actividades = new ServicioDatos().ObtenerListaActividades();
        }
        private void OnActividadActualizada(Actividad actividad)
        {
            ActividadActualizada(this, new ActividadEventArgs(actividad));
        }
        public void ActualizarActividad(Actividad actividad)
        {
            OnActividadActualizada(actividad);
        }

        public Actividad ObtenerActividad(int Id)
        {
            return _actividades.Where(p => p.Id == Id).First() as Actividad;
        }

        public IEnumerable<Actividad> ObtenerActividades()
        {
            return _actividades;
        }
    }

}

    
