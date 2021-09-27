using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludoMVPPasivoWindowsFormsApp
{
    public partial class SaludoForm : Form, IVista
    {
        private Presentador _presentador;
        public SaludoForm(IModelo modelo)
        {
            InitializeComponent();
            _presentador = new Presentador(this, modelo);
            saludoButton.Click += _presentador.saludoButton_Click;
        }
        public string Nombre
        {
            get { return nombreTextBox.Text; }
            set { nombreTextBox.Text = value; }
        }
        public string MensajePedirNombre
        {
            get { return nombreLabel.Text; }
            set { nombreLabel.Text = value; }
        }
        public string MensajeSaludo
        {
            get { return saludoLabel.Text; }
            set { saludoLabel.Text = value; }
        }
        public string MensajeBoton
        {
            get { return saludoButton.Text; }
            set { saludoButton.Text = value; }
        }

      
    }
}
