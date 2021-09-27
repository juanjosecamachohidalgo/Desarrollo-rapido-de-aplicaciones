using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosteActividades
{
    public interface IActividad
    {
        int Id { get; set; }
        string Nombre { get; set; }
        double PrecioEstimado { get; set; }
        double PrecioActual { get; set; }
        void Actualizar(IActividad actividad);
    }
    public class Actividad : IActividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PrecioEstimado { get; set; }
        public double PrecioActual { get; set; }
        public void Actualizar(IActividad actividad)
        {
            Nombre = actividad.Nombre;
            PrecioEstimado = actividad.PrecioEstimado;
            PrecioActual = actividad.PrecioActual;
        }
    }

}
