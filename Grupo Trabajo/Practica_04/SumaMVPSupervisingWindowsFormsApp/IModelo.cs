using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMVPSupervisingWindowsFormsApp
{
    public delegate void SumaEventHandler(object sender, SumaEventArgs e);
    public class SumaEventArgs : EventArgs
    {
        public string NumeroA { get; set; }
        public string NumeroB { get; set; }
        public SumaEventArgs(string numeroA, string numeroB) { this.NumeroA = numeroA; this.NumeroB = numeroB; }
    }


    public interface IModelo
    {
        string NumeroA { get; set; }
        string NumeroB { get; set; }

        event SumaEventHandler Suma;
    }
}
