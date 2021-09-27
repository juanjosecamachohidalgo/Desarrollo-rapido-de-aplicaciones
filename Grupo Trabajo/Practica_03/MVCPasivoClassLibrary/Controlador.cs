using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPasivoClassLibrary
{
    public class Controlador
    {
        private IModelo _modelo;
        private IVista _vista;

        public Controlador(IModelo modelo, IVista vista)
        {
            this._modelo = modelo;
            this._vista = vista;
            vista.Controlador = this;
        }
        public void ConvertirCantidadAEuros(string cantidad)
        {
            _modelo.Cantidad = Double.Parse(cantidad);
           String valor =  String.Format("{0:0.00}",Math.Round(_modelo.Cantidad / 166.386, 2));
            _vista.Cantidad = valor + " euros";
        }

        public void ConvertirCantidadAPesetas(string cantidad)
        {
            _modelo.Cantidad = Double.Parse(cantidad);
            String valor = String.Format("{0:0.00}", Math.Round(_modelo.Cantidad * 166.386, 2));
            _vista.Cantidad = valor + " pesetas";
        }

        public string MostrarMensajeCambio()
        {
           return _vista.MensajeCambio;
           
        }

        public string MostrarMensajeIntro()
        {
            return _vista.MensajeIntro;
        }
    }
}
