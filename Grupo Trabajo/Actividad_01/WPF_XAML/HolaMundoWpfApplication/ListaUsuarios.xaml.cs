using System;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using System.Xml;

namespace HolaMundoWpfApplication
{
    /// <summary>
    /// Lógica de interacción para ListaUsuarios.xaml
    /// </summary>
    public partial class ListaUsuarios : Window
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        void Filtro_Mayores(object sender, FilterEventArgs e)
        {
            e.Accepted = false;
            var xlmPersona = (e.Item as XmlElement);
            if (xlmPersona != null)
            {
                XmlNode xnEdad= xlmPersona.LastChild;
                int edadPersona = int.Parse(xnEdad.InnerText);
                if (edadPersona > 50) e.Accepted = true;
                else e.Accepted = false;
            }
        }      
    }
    public class UsuarioConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            string nombre = "", apellidos = "";
            XmlElement xml = (XmlElement)value;
            XmlNode xnNombre = xml.FirstChild;
            nombre = xnNombre.InnerText;
            XmlNode xnApellidos = xml.FirstChild.NextSibling;
            apellidos = xnApellidos.InnerText;

            return nombre + " " + apellidos;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("No implementado");
        }
    }
}

