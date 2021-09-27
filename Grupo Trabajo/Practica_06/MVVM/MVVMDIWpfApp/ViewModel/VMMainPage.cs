using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDIWpfApp.ViewModel
{
    public class VMMainPage : VMBase
    {
        private string text;

        public VMMainPage()
        {
        }

        public string Text
        {
            get 
            {
                return this.text;
            }
            set
            {
                this.text = value;
                RaisePropertyChanged("Text");
            }
        }
    }
}
