using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMVPPasivoWindowsFormsApp
{
    interface IVista
    {
        string MensajeResultado { get; set; }
        string Cantidad1 {get; set;}
        string Cantidad2 { get; set; }
        string MensajeBoton { get; set; }
    }
}
