using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaMVPPasivoWindowsFormsApp
{
    public partial class SumaForm : Form, IVista
    {
        private Presentador _presentador;
        public SumaForm(IModelo modelo)
        {
            InitializeComponent();
            _presentador = new Presentador(this, modelo);
            sumaButton.Click += _presentador.sumaButton_Click;
        }

        public string MensajeResultado
        {
            get
            {
                return resultadoLabel.Text;
            }
            set
            {
                resultadoLabel.Text = value;
            }
        }

        public string Cantidad1
        {
            get
            {
                return primeraCantidadTextBox.Text;
            }
            set
            {
                primeraCantidadTextBox.Text = value;
            }
        }

        public string Cantidad2
        {
            get
            {
                return segundaCantidadTextBox.Text;
            }
            set
            {
                segundaCantidadTextBox.Text = value;
            }
        }

        public string MensajeBoton
        {
            get
            {
                return sumaButton.Text;
            }
            set
            {
                sumaButton.Text = value;
            }
        }
    }
}
