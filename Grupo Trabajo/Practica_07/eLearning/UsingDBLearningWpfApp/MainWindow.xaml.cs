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
using LearningClassLibrary.Data;

namespace UsingDBLearningWpfApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LearningContext db = new LearningContext();
            db.Database.CreateIfNotExists();
            LearningContextMigrationConfiguration confDB = new LearningContextMigrationConfiguration();
            LearningDataSeeder ls = new LearningDataSeeder(db);
            db.SaveChanges();
        }
    }
}
