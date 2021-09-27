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

namespace UsingDBLearningWpfApp.Views
{
    /// <summary>
    /// Lógica de interacción para Tutors.xaml
    /// </summary>
    public partial class Tutors : Window
    {
        public Tutors()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource tutorViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tutorViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // tutorViewSource.Source = [origen de datos genérico]
        }
    }
}
