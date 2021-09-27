using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaMVPSupervisingWindowsFormsApp
{
    public partial class SumaForm : Form, IVista
    {
        private Presentador _presentador;
        public SumaForm(IModelo modelo)
        {
            InitializeComponent();
            _presentador = new Presentador(this, modelo);            
            butSumar.Click += SumarButton_Click;
            modelo.Suma += Modelo_Suma;
        }
        public void Modelo_Suma(object sender, SumaEventArgs e)
        {
            MensajeResultado = _presentador.GenerarSuma(e.NumeroA, e.NumeroB);
        }
        public void SumarButton_Click(object sender, EventArgs e)
        {
            _presentador.SumaButton_Click(sender, e);
        }
        public string MensajePedirNumeros
        {
            get { return labMensaje.Text; }
            set { labMensaje.Text = value; }
        }
        public string NumeroA { get { return textNumeroA.Text; } }
        public string NumeroB { get { return textNumeroB.Text; } }
        public string MensajeResultado
        {
            get { return labResultado.Text; }
            set { labResultado.Text = value; }
        }

    }
}
