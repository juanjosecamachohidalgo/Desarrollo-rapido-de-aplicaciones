using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMVPSupervisingWindowsFormsApp
{
    public interface IVista
    {
        string MensajePedirNumeros { get; set; }
        string NumeroA { get; }
        string NumeroB { get; }
        string MensajeResultado { get; }
        void SumarButton_Click(object sender, EventArgs e);
    }
}
