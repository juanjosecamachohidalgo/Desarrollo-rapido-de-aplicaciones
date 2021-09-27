using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludoMVPSupervisingWindowsFormsAp
{
   public partial class SaludoForm : Form, IVista
    {
        private Presentador _presentador;
        public SaludoForm(IModelo modelo)
        {
            InitializeComponent();
            _presentador = new Presentador(this, modelo);
            saludoButton.Click += SaludoButton_Click;
            modelo.Saludo += Modelo_Saludo;
        }
        public void Modelo_Saludo(object sender, SaludoEventArgs e)
        {
            MensajeSaludo = _presentador.GenerarSaludo(e.Saludo);
        }
        public void SaludoButton_Click(object sender, EventArgs e)
        {
            _presentador.SaludoButton_Click(sender, e);
        }
        public string MensajePedirNombre
        {
            get { return nombreLabel.Text; }
            set { nombreLabel.Text = value; }
        }
        public string Nombre { 
            get { return nombreTextBox.Text; } 
            set { nombreTextBox.Text = value; } }
        public string MensajeSaludo
        {
            get { return saludoLabel.Text; }
            set { saludoLabel.Text = value; }
        }
    }
}
