using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HolaMundoWpfApplication
{
    /// <summary>
    /// Lógica de interacción para CambiarPalabraPaso.xaml
    /// </summary>
    public partial class CambiarPalabraPaso : Window
    {
      
        public CambiarPalabraPaso()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            string valorActual = this.valorActualTextBox.Text;
            string nuevoValor = this.nuevoValorTextBox.Text;
            string repetirNuevoValor = this.repetirNuevoValorTextBox.Text;

            if (nuevoValor == UsuarioActivo.PalabraDePaso) MessageBox.Show(" El nuevo valor debe ser distinto del anterior ");
            else
            if (nuevoValor != repetirNuevoValor) MessageBox.Show(" El nuevo valor no coincide ");
            else
                if (valorActual != UsuarioActivo.PalabraDePaso) MessageBox.Show(" El valor actual no coincide ");
                else
                {
                    UsuarioActivo.PalabraDePaso = nuevoValor;
                    MessageBox.Show(" La palabra de paso ha sido cambiada. ");
                    this.Close();
                }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
