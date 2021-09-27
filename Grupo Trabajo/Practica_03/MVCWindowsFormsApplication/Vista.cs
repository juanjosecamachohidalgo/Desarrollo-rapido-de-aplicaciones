using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCPasivoClassLibrary;

namespace MVCWindowsFormsApplication
{
    public partial class Vista : Form, IVista
    {
        private Controlador _controlador;
        public Vista()
        {
            InitializeComponent();
        }

        public Controlador Controlador
        {
            get
            {
                return _controlador;
            }
            set
            {
                _controlador = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return cantidadTextBox.Text;
            }
            set
            {
                CambioLabel.Text = value;
            }
        }

        public string MensajeCambio
        {
            get
            {
                return CambioLabel.Text;
            }
            set
            {
                CambioLabel.Text = "Son " + value;
            }
        }

        public string MensajeIntro
        {
            get
            {
                return IntroTextBox.Text;
            }
            set
            {
                IntroTextBox.Text = "¿Que cantidad desea introducir?";
            }
        }

        private void pesetasButton_Click(object sender, EventArgs e)
        {
            _controlador.ConvertirCantidadAPesetas(Cantidad);
        }

        private void eurosButton_Click(object sender, EventArgs e)
        {
            _controlador.ConvertirCantidadAEuros(Cantidad);
        }
    }
}
