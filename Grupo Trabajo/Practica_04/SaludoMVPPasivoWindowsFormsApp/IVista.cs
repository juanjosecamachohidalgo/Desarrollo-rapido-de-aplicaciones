using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoMVPPasivoWindowsFormsApp
{
    public interface IVista
    {
        string MensajePedirNombre { get; set; }
        string MensajeSaludo { get; set; }
        string Nombre { get; set; }
        string MensajeBoton { get; set; }
    }
}
