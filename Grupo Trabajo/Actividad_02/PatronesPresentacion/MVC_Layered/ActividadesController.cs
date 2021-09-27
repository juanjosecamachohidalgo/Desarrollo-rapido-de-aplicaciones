using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Layered.Business;
using CosteActividades;
using CosteActividades.ServicioDatos;
using System.Windows;

namespace MVC_Layered.UI
{

    public interface IActividadesController
    {
        void MostrarActividadesView(Window ventana);
        void Actualizar(Actividad actividad);
    }
    public class ActividadesController : IActividadesController
    {
        private readonly IActividadesModel _modelo;
        public ActividadesController(IActividadesModel actividadModel)
        {
            if (actividadModel == null)
                throw new ArgumentNullException("actividadModel");
            _modelo = actividadModel;
        }
        public void MostrarActividadesView(Window ventana)
        {
            ActividadesView view = new ActividadesView(this, _modelo);
            view.Owner = ventana;
            view.Show();
        }
        public void Actualizar(Actividad actividad)
        {
            _modelo.ActualizarActividad(actividad);
        }
    }

}
