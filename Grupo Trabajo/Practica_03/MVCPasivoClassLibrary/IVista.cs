using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPasivoClassLibrary
{
    public interface IVista
    {
        Controlador Controlador { get; set; }
        string Cantidad { get; set; }
        string MensajeCambio { get; set; }
        string MensajeIntro { get; set; }
    }
}
