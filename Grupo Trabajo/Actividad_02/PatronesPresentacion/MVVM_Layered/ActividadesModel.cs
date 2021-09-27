using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosteActividades;
using CosteActividades.ServicioDatos;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MVVM_Layered.Business
{

    public class ActividadEventArgs : EventArgs
    {
        public IActividad Actividad { get; set; }
        public ActividadEventArgs(IActividad actividad)
        {
            Actividad = actividad;
        }
    }

    public interface IActividadesModel
    {
        ObservableCollection<Actividad> Actividades { get; set; }
        void ActualizarActividad(IActividad actividad);
        event EventHandler<ActividadEventArgs> ActividadActualizada;
        Actividad ObtenerActividad(int Id);
    }
    public class ActividadesModel : IActividadesModel
    {
        public ObservableCollection<Actividad> Actividades { get; set; }
        public event EventHandler<ActividadEventArgs> ActividadActualizada = delegate { };
        public ActividadesModel(IServicioDatos servicioDatos)
        {
             Actividades = new ObservableCollection<Actividad>(); 
            foreach (Actividad actividad in servicioDatos.ObtenerListaActividades())
            {
                Actividades.Add(actividad);
            }
        }
        private void OnActividadActualizada(IActividad actividad)
        {
            ActividadActualizada(this, new ActividadEventArgs(actividad));
        }
        public void ActualizarActividad(IActividad actividad)
        {
            ObtenerActividad(actividad.Id).Actualizar(actividad); 
            OnActividadActualizada(actividad);
        }

        public Actividad ObtenerActividad(int Id)
        {
            return Actividades.Where(p => p.Id == Id).First() as Actividad;
        }

        public ObservableCollection<Actividad> ObtenerActividades()
        {
            return Actividades;
        }


    }

}

    
