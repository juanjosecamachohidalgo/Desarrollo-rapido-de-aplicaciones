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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVP_Layered.Business;

namespace MVP_Layered.UI
{

    public partial class MainWindow : Window
    {   
            private IActividadesModel _modelo = null;
            public MainWindow()
            {
                InitializeComponent();
                _modelo = new ActividadesModel();
            }
            private void MostrarActividadesButton_Click(object sender, RoutedEventArgs e)
            {
                ActividadesView vista = new ActividadesView();
                ActividadesPresenter presenter = new ActividadesPresenter(vista, _modelo);
                vista.Owner = this;
                vista.Show();
            }        
    }
}
