using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace MVVMDIWpfApp.ViewModel
{
    public class VMLocator
    {
        IUnityContainer container = new UnityContainer();

        public VMLocator()
        {
            container.RegisterInstance<VMMainPage>(new VMMainPage(), new TransientLifetimeManager());
        }

        public VMMainPage MainViewModel
        {
            get
            {
                return container.Resolve<VMMainPage>();
            }
        }

        /*
        private Lazy<VMMain> mainViewModel;

        public VMLocator()
        {
            mainViewModel = new Lazy<VMMain>(() => new VMMain());
        }

        public VMMain MainViewModel
        {
            get
            {
                return mainViewModel.Value;
            }
        }
        */
    }

}
