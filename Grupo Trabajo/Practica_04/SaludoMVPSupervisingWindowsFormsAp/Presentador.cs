using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoMVPSupervisingWindowsFormsAp
{
    public class Presentador
    {
        public IVista _vista;
        public IModelo _modelo;
        public Presentador(IVista vista, IModelo Modelo)
        {
        _modelo = Modelo;
        _vista = vista;
        }
        public void SaludoButton_Click(object sender, EventArgs e)
        {
            _modelo.Nombre = _vista.Nombre;
        }
        public string GenerarSaludo(string nombre)
        {
            return string.Format("Hola {0} ", nombre);
        }
    }
}
