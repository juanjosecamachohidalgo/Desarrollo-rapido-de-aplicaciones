using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCPasivoClassLibrary;

namespace MVCWindowsFormsApplication
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form vista = new Vista();
           
            IModelo modelo = new Modelo();
            Controlador controlador = new Controlador(modelo, (IVista)vista);
            controlador.MostrarMensajeIntro();
            Application.Run(vista);
        }
    }
}
