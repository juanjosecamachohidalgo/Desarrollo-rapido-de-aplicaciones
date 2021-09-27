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
    /// Lógica de interacción para Courses.xaml
    /// </summary>
    public partial class Courses : Window
    {
        private LearningContext _context = new LearningContext();

        public Courses()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource courseViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("courseViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // courseViewSource.Source = [origen de datos genérico]
            _context.Courses.Load();
            courseViewSource.Source = _context.Courses.Local;
        }
    }
}
