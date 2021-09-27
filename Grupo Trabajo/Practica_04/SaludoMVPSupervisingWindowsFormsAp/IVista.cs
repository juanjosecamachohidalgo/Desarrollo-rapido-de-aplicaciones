using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoMVPSupervisingWindowsFormsAp
{
    public interface IVista
    {
        string MensajePedirNombre { get; set; }
        string Nombre { get; set; }
        string MensajeSaludo { get; set; }
        void SaludoButton_Click(object sender, EventArgs e);
    }
}
