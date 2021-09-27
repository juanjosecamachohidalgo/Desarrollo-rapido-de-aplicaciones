using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace SampleMVVMWpfApplication.ViewModel
{
    public class VMMain : VMBase
    {
        private string text = string.Empty;

        private Lazy<DelegateCommand<string>> sayHelloCommand;

        public VMMain()
        {
            sayHelloCommand = new Lazy<DelegateCommand<string>>
            (
                () => new DelegateCommand<string>(SayHelloCommandExecute, 
                                                  SayHelloCommandCanExecute)
            );
        }

        public ICommand SayHelloCommand
        {
            get
            {
                return sayHelloCommand.Value;
            }
        }

        public void SayHelloCommandExecute(string param)
        {
            string msg = string.Format("Hello {0}", param);
            MessageBox.Show(msg);
        }

        public bool SayHelloCommandCanExecute(string param)
        {
            if (!string.IsNullOrEmpty(param) && param.ToLowerInvariant() == "antonio")
                return true;

            return false;
        }

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                RaisePropertyChanged("Text");
                sayHelloCommand.Value.RaiseCanExecuteChanged();
            }
        }
    }
}
