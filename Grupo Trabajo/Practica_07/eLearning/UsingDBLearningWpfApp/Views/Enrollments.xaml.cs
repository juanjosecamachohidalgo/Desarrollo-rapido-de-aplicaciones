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
using System.Data.Entity;
using LearningClassLibrary.Data;

namespace UsingDBLearningWpfApp.Views
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private LearningContext _context = new LearningContext();

        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource enrollmentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("enrollmentViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // enrollmentViewSource.Source = [origen de datos genérico]
            _context.Enrollments.Load();
            enrollmentViewSource.Source = _context.Enrollments.Local;
        }
    }
}
