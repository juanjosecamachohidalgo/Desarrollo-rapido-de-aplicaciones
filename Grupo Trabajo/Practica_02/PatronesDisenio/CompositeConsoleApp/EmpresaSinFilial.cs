using System;

namespace CompositeConsoleApp
{
    public class EmpresaSinFilial : Empresa
    {
        public override bool agregaFilial(Empresa filial)
        {
            return false;
        }
        public override bool agregaStartup(Empresa startup)
        {
            return false;
        }
        public override double calculaCosteMantenimiento()
        {
            return nVehiculos * costeUnitarioVehiculo;
        }
    }
}

