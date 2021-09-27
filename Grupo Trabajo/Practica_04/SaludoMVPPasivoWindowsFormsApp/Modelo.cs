using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoMVPPasivoWindowsFormsApp
{
    public class Modelo : IModelo
    {
        public string Nombre { get; set; }
        public string GenerarSaludo(string mensaje)
        {
            return string.Format(mensaje + " {0} ", Nombre);
        }
    }
}
