using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVMWpfApplication.ViewModel
{
    public class VMBase : INotifyPropertyChanged
    {
        public VMBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, 
                    new PropertyChangedEventArgs(propertyName));
        }
    }
}
