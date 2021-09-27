using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SaludoMVVMWpfApplication
{
    public class HolaViewModel: INotifyPropertyChanged
    {
        IModelo _modelo;
        public HolaViewModel(IModelo modelo)
        {
            _modelo = modelo;
        }
        private string _mensajeSaludo;
        public string MensajeSaludo
        {
            get
            {
                return _mensajeSaludo;
            }
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
            get
            {
                return _nombre;
            }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged("Nombre");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string nombrePropiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
            }
        }
        
        ICommand _holaCommand;
        public ICommand HolaCommand
        {
            get
            {
                if(_holaCommand == null) 
                    _holaCommand = new Command(HolaSaludo);
                return _holaCommand;
            }
        }
        private void HolaSaludo(object parameter)
        {
            MensajeSaludo = "Hola " + _nombre;
        }

       
    }
}
