using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeConsoleApp
{
    public class FormRtfImpl : FormularioImpl
    {
        public void dibujaTexto(string texto)
        {
            Console.WriteLine("RTF: " + texto);
        }

        public string administraZonaIndicada()
        {
            return Console.ReadLine();
        }
    }
}
