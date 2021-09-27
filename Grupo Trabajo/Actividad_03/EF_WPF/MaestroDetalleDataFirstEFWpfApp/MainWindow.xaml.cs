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
using System.Data.Entity;

namespace MaestroDetalleDataFirstEFWpfApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductoModel _context = new ProductoModel();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource categoriasViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("categoriasViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // categoriasViewSource.Source = [origen de datos genérico]
            _context.Categorias.Load();
            categoriasViewSource.Source = _context.Categorias.Local; 
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var producto in _context.Productoes.Local.ToList())
            {
                if (producto.Categorias == null)
                {
                    _context.Productoes.Remove(producto);
                }
            }

            _context.SaveChanges();
            this.categoriasDataGrid.Items.Refresh();
            this.productoesDataGrid.Items.Refresh();
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

    }
}
