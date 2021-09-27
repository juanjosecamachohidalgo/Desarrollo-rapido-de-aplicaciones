using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MVVMServicesWpfApp.ViewModels;
using MVVMServicesWpfApp.Services.UXService;

namespace MVVMServicesWpfApp.ViewModels.Base
{
    public class VMLocator
    {
        IContainer container;

        public VMLocator()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<VMMainPage>();
            builder.RegisterType<UXService>().As<IUXService>();

            container = builder.Build();
        }

        public VMMainPage MainViewModel
        {
            get
            {
                return container.Resolve<VMMainPage>();
            }
        }
    }
}
