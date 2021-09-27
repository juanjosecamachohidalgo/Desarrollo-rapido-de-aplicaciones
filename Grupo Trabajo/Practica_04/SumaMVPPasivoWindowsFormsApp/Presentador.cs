using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMVPPasivoWindowsFormsApp
{
    class Presentador
    {
        private IVista _vista;
        private IModelo _modelo;
        public Presentador(IVista Vista, IModelo Modelo)
        {
            _vista = Vista;
            _modelo = Modelo;
        }

        internal void sumaButton_Click(object sender, EventArgs e)
        {
            _modelo.Cantidad1 = _vista.Cantidad1;
            _modelo.Cantidad2 = _vista.Cantidad2;
            string resultadoMensaje = _modelo.Resultado(Double.Parse(_vista.Cantidad1), Double.Parse(_vista.Cantidad2));
            _vista.MensajeResultado = resultadoMensaje;
        }
    }
}
