using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SumaMVVMWpfApplication
{

    public class SumaVM : INotifyPropertyChanged
    {
        private Modelo _mod { get; set; }
        public SumaVM(Modelo mod)
        {
            _mod = mod;
        }
        
        public int Num1
        {
            get
            {
                return _mod.Num1;
            }
            set
            {
                if (value != _mod.Num1)
                {
                    _mod.Num1 = value;
                    OnPropertyChanged("Num1");
                    //OnPropertyChanged("Suma"); 

                }
            }
        }

        public int Num2
        {
            get
            {
                return _mod.Num2;
            }
            set
            {
                if (value != _mod.Num2)
                {
                    _mod.Num2 = value;
                    OnPropertyChanged("Num2");
                    //OnPropertyChanged("Suma"); 

                }
            }
        }

        int _resultado;
        public int Resultado
        {
            get
            {
                return _resultado;
            }
           
        }

        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        ICommand _operationCommand;
        public ICommand OperationCommand
        {
            get
            {
                if (_operationCommand == null)
                {
                    _operationCommand = new Command(EjecutaOperacion);
                }
                return _operationCommand;
            }
        }
        private void EjecutaOperacion(object parameter)
        {
            if (parameter.ToString() == "Suma")
                _resultado = Num1 + Num2;
            else if (parameter.ToString() == "Resta")
                _resultado = Num1 - Num2;
            else if (parameter.ToString() == "Multiplica")
                _resultado = Num1 * Num2;

            OnPropertyChanged("Resultado");
        }
    }
}
