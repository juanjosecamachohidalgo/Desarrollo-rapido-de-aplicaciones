using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosteActividades.ServicioDatos;
using CosteActividades;

namespace MonoliticoWFA
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            CargarActividades();
            OcultarDetalles();
            this.actualizarButton.Click += actualizarButton_Click;
        }

        void actualizarButton_Click(object sender, EventArgs e)
        {
           Actividad actividadSeleccionada  = this.listaActividadesComboBox.SelectedItem  as Actividad;
           if (actividadSeleccionada != null)
           {
               actividadSeleccionada.PrecioEstimado = double.Parse(precioEstimadoLabel.Text);
               if (!string.IsNullOrEmpty(precioActualTextBox.Text))
               {
                   actividadSeleccionada.PrecioActual = double.Parse(precioActualTextBox.Text);
               }
               PonerColor(actividadSeleccionada);
           }
        }


        private void CargarActividades()
        {
            foreach (Actividad actividad in new ServicioDatos().ObtenerListaActividades())
            {
                this.listaActividadesComboBox.Items.Add(actividad);
            }
            this.listaActividadesComboBox.DisplayMember = "Nombre";
            this.listaActividadesComboBox.SelectedIndexChanged += listaActividadesComboBox_SelectedIndexChanged;
        }


        void listaActividadesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedIndex > -1)
            {
                MostrarDetalles();
            }
            else
            {
                OcultarDetalles();
            }
        }

        private void OcultarDetalles()
        {
            precioEstimadoLabel.Enabled = false;
            precioActualTextBox.Enabled = false;
            actualizarButton.Enabled = false;
        }

        private void MostrarDetalles()
        {
           Actividad actividadSeleccionada = this.listaActividadesComboBox.SelectedItem  as Actividad;
           precioEstimadoLabel.Enabled = true;
           precioEstimadoLabel.Text = actividadSeleccionada.PrecioEstimado.ToString();
           precioActualTextBox.Enabled = true;
           precioActualTextBox.Text = (actividadSeleccionada.PrecioActual == 0) ? "" : actividadSeleccionada.PrecioActual.ToString();
           PonerColor(actividadSeleccionada);
           actualizarButton.Enabled = true;
        }

        private void PonerColor(Actividad actividadSeleccionada)
        {
            if (actividadSeleccionada.PrecioActual < actividadSeleccionada.PrecioEstimado)
                this.precioEstimadoLabel.ForeColor = Color.Green;
            else
                if (actividadSeleccionada.PrecioActual > actividadSeleccionada.PrecioEstimado)
                    this.precioEstimadoLabel.ForeColor = Color.Red;
                else
                    this.precioEstimadoLabel.ForeColor = Color.Black;
            
        }
    }
}
