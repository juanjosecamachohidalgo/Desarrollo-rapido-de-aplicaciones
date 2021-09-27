using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMVPSupervisingWindowsFormsApp
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
        public void SumaButton_Click(object sender, EventArgs e)
        {
            _modelo.NumeroA = _vista.NumeroA;
            _modelo.NumeroB = _vista.NumeroB;
        }
        public string GenerarSuma(string numeroA, string numeroB)
        {
            float valA, valB;
            float.TryParse(numeroA, out valA);
            float.TryParse(numeroB, out valB);
            return string.Format("La suma es  {0} ", valA + valB);
        }
    }
}
