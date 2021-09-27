using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoMVPPasivoWindowsFormsApp
{
    public class Presentador
    {
        private IVista _vista;
        private IModelo _modelo;
        public Presentador(IVista Vista, IModelo Modelo)
        {
            _vista = Vista;
            _modelo = Modelo;
        }
        public void saludoButton_Click(object sender, EventArgs e)
        {
            _modelo.Nombre = _vista.Nombre;
            string saludoMensaje = _modelo.GenerarSaludo("Hola ");
            _vista.MensajeSaludo = saludoMensaje;
        }
    }
}
