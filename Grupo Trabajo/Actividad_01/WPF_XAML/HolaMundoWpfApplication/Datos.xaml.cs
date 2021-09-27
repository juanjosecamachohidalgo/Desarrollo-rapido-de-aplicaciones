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
using System.ComponentModel;
using System.Globalization;

namespace HolaMundoWpfApplication
{
    /// <summary>
    /// Lógica de interacción para Datos.xaml
    /// </summary>
    public partial class Datos : Window
    {
        public Datos()
        {
            InitializeComponent();
            Persona persona = new Persona();
            DataContext = persona;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as Persona).EdadPersona++;
            MessageBox.Show(String.Format(" Nombre {0}; \n Apellidos {1}; \n Edad {2}",(DataContext as Persona).NombrePersona,
                (DataContext as Persona).ApellidosPersona,(DataContext as Persona).EdadPersona));
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    

  // La clase persona implementa INotifyPropertyChanged para soportar binding en el modo one-way y two-way
  // de esta forma los elemento de Interface de Usuario se actualizan dinámicamente cuando la fuente se cambia

    public class Persona : DependencyObject, INotifyPropertyChanged, IDataErrorInfo
  {
      private string _nombrePersona;
      private string _apellidosPersona;
 
      public event PropertyChangedEventHandler PropertyChanged;

      public string NombrePersona
      {
          get { return _nombrePersona; }
          set
          {
              _nombrePersona = value;
              OnPropertyChanged("NombrePersona");
          }
      }

      public string ApellidosPersona
      {
          get { return _apellidosPersona; }
          set
          {
              _apellidosPersona = value;
              OnPropertyChanged("ApellidosPersona");
          }
      }

      protected void OnPropertyChanged(string name)
      {
          PropertyChangedEventHandler handler = PropertyChanged;
          if (handler != null)
          {
              handler(this, new PropertyChangedEventArgs(name));
          }
      }

      // Age is a dependency property
      public static readonly DependencyProperty EdadProperty;

      // Call methods in DependencyObject to read/write property values
      public int EdadPersona
      {
          get { return (int)GetValue(EdadProperty); }
          set { SetValue(EdadProperty, value); OnPropertyChanged("EdadPersona"); }
      }


              // Static constructor sets everything up
       static Persona()
        {
            PropertyMetadata edadMetadata =
                new PropertyMetadata(
                    18,     // Default value
                    new PropertyChangedCallback(OnEdadChanged),
                    new CoerceValueCallback(OnEdadCoerceValue));

            // Register the property
            EdadProperty =
                DependencyProperty.Register(
                    "Edad",                 // Property's name
                    typeof(int),           // Property's type
                    typeof(Persona),        // Defining class' type
                    edadMetadata,           // Defines default value & callbacks  (optional)
                    new ValidateValueCallback(OnEdadValidateValue));   // validation (optional)
        }

        // Value has changed
        private static void OnEdadChanged
            (DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            Persona p = (Persona)depObj;
        }

        // Allow coercing value being set
        private static object OnEdadCoerceValue
            (DependencyObject depObj, object baseValue)
        {
            int coercedValue = (int)baseValue;

            if ((int)baseValue > 100)
                coercedValue = 100;

            if ((int)baseValue < 18)
                coercedValue = 18;

            return coercedValue;
        }

        // Validate a value beint set
        private static bool OnEdadValidateValue(object value)
        {
            int v;
            try
            {
                 v = (int)value;
                if (v > 0) return true;
            }
            catch
            {
                return false;
            }
               
            return false;
        }


        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get
            {
                string result = null;

                //basically we need one of these blocks
                //for each property you wish to validate
                switch (columnName)
                {
                    case "ApellidosPersona":
                        if (string.IsNullOrEmpty(ApellidosPersona))
                        {
                            result = "El campo Apellidos no puede estar vacio.";
                        }
                        break;

                    case "NombrePersona":
                        if (string.IsNullOrEmpty(NombrePersona))
                        {
                            result = "El campo Nombre no puede estar vacio.";
                        }
                        else
                        {
                            if (this.NombrePersona.Length > 8)
                            {
                                result = "El campo Nombre no puede tener más de 8 caracteres.";
                            }
                        }
                        if (this.NombrePersona == string.Empty)
                        {
                            result = "El campo Nombre no puede estar vacio.";
                        }
                        break;
                    default:
                        break;
                }

                return result;
            }

        }
  }

    public class EdadRule : ValidationRule
    {
        public override ValidationResult Validate(object value,  CultureInfo cultureInfo)
        {
            int edad = 0;
            try
            {
    
                edad = int.Parse(value.ToString());
            }
            catch 
            {
                return new ValidationResult(false,
                           "Tiene que ser un número entero sin decimales.");
            }

            if (edad <= 0)
            {
                return new ValidationResult(false,
                   "Tiene que ser mayor que cero.");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }

}




