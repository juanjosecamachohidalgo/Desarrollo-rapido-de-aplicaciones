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
    /// Lógica de interacción para GridUsuarios.xaml
    /// </summary>
    public partial class ColeccionUsuarios : Window
    {
        public ColeccionUsuarios()
        {
            InitializeComponent();
        }

        void Filtro_NombreEmpiezaPorA(object sender, FilterEventArgs e)
        {
            var item = (e.Item) as UsuarioModel; 
            if (item.Nombre.StartsWith("A"))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }

    }
}
