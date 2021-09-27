using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoMVPPasivoWindowsFormsApp
{
    public interface IModelo
    {
        string Nombre { get; set; }
        string GenerarSaludo(string mensaje);
    }
}
