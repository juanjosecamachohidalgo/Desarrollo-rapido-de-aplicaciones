using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeConsoleApp
{
    class EmpresaStartup : Empresa
    {
        public override bool agregaFilial(Empresa filial)
        {
            return false;
        }
        public override bool agregaStartup(Empresa filial)
        {
            return false;
        }


        public override double calculaCosteMantenimiento()
        {
            return 2 + nVehiculos * costeUnitarioVehiculo;
        }
    }
}
