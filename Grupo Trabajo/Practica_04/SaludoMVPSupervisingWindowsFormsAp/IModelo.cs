using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoMVPSupervisingWindowsFormsAp
{
    public delegate void SaludoEventHandler(object sender, SaludoEventArgs e);
    public class SaludoEventArgs : EventArgs
    {
        public string Saludo { get; set; }
        public SaludoEventArgs(string Saludo) { this.Saludo = Saludo; }
    }
    public interface IModelo
    {
        string Nombre { get; set; }
        event SaludoEventHandler Saludo;
    }
}
