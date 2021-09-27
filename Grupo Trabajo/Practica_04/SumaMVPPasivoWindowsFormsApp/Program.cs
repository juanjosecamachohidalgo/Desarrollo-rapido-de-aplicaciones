using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaMVPPasivoWindowsFormsApp
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
            SumaForm sumaForm = new SumaForm(modelo);
            sumaForm.MensajeResultado = "";
            sumaForm.MensajeBoton = "Sumar";
            Application.Run(sumaForm);
        }
    }
}
