using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosteActividades.ServicioDatos
{
    public interface IServicioDatos
    {
        IList<Actividad> ObtenerListaActividades();
    }

    public class ServicioDatos : IServicioDatos
    {
        public IList<Actividad> ObtenerListaActividades()
        {
            List<Actividad> listaActividades = new List<Actividad>() 
            {
                new Actividad() { Id = 0,Nombre = "Pintar",PrecioEstimado = 500 },
                new Actividad() { Id = 1,Nombre = "Lavar",PrecioEstimado = 300 },
                new Actividad() { Id = 2,Nombre = "Reparar",PrecioEstimado = 1500 },
                new Actividad() { Id = 3,Nombre = "Limpiar",PrecioEstimado = 100 }
            };                
            return listaActividades;
        }
    }
}

