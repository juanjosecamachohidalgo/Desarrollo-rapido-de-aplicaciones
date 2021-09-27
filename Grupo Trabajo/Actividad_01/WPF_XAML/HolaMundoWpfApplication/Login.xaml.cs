using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private ICollection<UsuarioModel> _usuarios;
        public Login()
        {
            InitializeComponent();
           // _usuarios = new UsuariosModel();
            _usuarios = (UsuariosModel)FindResource("ListaUsuarios");
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            string nombreUsuario = usuarioTextBox.Text;
            string palabraDePaso = palabraDePasoTextBox.Text;
            string password;
            if (TryGetValue(nombreUsuario, out password))
            {
                if (password == palabraDePaso)
                {
                    UsuarioActivo.Nombre = nombreUsuario;
                    UsuarioActivo.PalabraDePaso = palabraDePaso;
                    MessageBox.Show(string.Format("Hola {0} ", nombreUsuario));
                    this.Hide(); // oculta la ventana actual
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show(); //muestra la ventana principal

                }
                else
                    MessageBox.Show(string.Format("Error en palabra de paso {0}", palabraDePaso));
            }
            else
                MessageBox.Show(string.Format("Error en nombre de usuario {0}", nombreUsuario));

            //MessageBox.Show(string.Format("Hola {0} ", usuarioTextBox.Text));
        }

        private bool TryGetValue(string Nombre, out string PalabraPaso)
        {
            PalabraPaso = null;
            foreach (var user in _usuarios)
            {
                if (user.Nombre == Nombre)
                {
                    PalabraPaso = user.PalabraDePaso;
                    return true;
                }
            }
            return false;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UsuariosComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var value = (sender as ComboBox).SelectedValue;
            usuarioTextBox.Text = value.ToString();
        }

    }
}
