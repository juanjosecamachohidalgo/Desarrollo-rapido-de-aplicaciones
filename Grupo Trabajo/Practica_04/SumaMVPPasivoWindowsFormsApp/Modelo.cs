using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMVPPasivoWindowsFormsApp
{
    public class Modelo: IModelo
    {
        public string Cantidad1 { get; set; }
        public string Cantidad2 { get; set; }

        public string Resultado(double cantidad1, double cantidad2)
        {
            double resultado = cantidad1 + cantidad2;
            return String.Format("{0}", resultado);
        }
    }
}
