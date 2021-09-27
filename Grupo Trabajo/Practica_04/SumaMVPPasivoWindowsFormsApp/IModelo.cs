using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMVPPasivoWindowsFormsApp
{
    public interface IModelo
    {
        string Cantidad1 { get; set; }
        string Cantidad2 { get; set; }
        string Resultado(double cantidad1, double cantidad2);
    }
}
