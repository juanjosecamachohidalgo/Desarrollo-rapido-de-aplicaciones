using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SumaMVVMWpfApplication
{
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
