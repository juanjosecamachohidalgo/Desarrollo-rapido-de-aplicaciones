using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludoMVPPasivoWindowsFormsApp
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
            IModelo modelo = new Modelo();
            SaludoForm saludoForm = new SaludoForm(modelo);
            saludoForm.MensajePedirNombre = "Escriba su nombre a continuación: ";
            saludoForm.MensajeSaludo = "";
            saludoForm.MensajeBoton = "Hacer Click";
            Application.Run(saludoForm);
        }
    }
}
