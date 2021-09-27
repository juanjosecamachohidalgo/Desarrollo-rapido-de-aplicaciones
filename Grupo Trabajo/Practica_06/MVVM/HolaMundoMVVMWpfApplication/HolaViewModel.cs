using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HolaMundoMVVMWpfApplication
{
    public class HolaViewModel : INotifyPropertyChanged
    {
        IModelo _modelo;
        public HolaViewModel(IModelo modelo)
        {
            _modelo = modelo;
        }
        private string _mensajeSaludo;
        public string MensajeSaludo
        {
            get { return _mensajeSaludo; }
            set 
            {
                if (_mensajeSaludo != value)
                {
                    _mensajeSaludo = value;
                    OnPropertyChanged("MensajeSaludo");
                }
            }
        }
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged("Nombre");
                }
            }
        }
        protected void OnPropertyChanged(string nombrePropiedad)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        ICommand _holaCommand;
        public ICommand HolaCommand
        {
            get
            {
                if (_holaCommand == null)
                {
                    _holaCommand = new Command(HolaSaludo);
                }
                return _holaCommand;
            }
        }
        private void HolaSaludo(object parameter)
        {
            MensajeSaludo = "hola " + _nombre;
        }
    }

    public delegate void CommandDelegate(object sender);

    public class Command : ICommand
    {
        CommandDelegate _command;
        public Command(CommandDelegate command)
        {
            _command = command;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _command(parameter);
        }
    }
    
}
