using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPasivoClassLibrary;

namespace MVCConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IVista vista = new VistaPesetas();
            //IVista vista = new VistaEuros();
            IModelo modelo = new Modelo();
            Controlador controlador = new Controlador(modelo, vista);
            controlador.MostrarMensajeIntro();
            
        }
    }
}
