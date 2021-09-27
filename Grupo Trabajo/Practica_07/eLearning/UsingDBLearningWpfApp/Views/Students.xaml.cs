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
    /// Lógica de interacción para Students.xaml
    /// </summary>
    public partial class Students : Window
    {
        private LearningContext _context = new LearningContext();

        public Students()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource studentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // studentViewSource.Source = [origen de datos genérico]
            _context.Students.Load();
            studentViewSource.Source = _context.Students.Local;
        }
    }
}
