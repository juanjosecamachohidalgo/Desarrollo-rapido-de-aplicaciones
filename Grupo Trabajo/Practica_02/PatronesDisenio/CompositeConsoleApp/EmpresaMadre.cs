using System;
using System.Collections.Generic;

namespace CompositeConsoleApp
{
    public class EmpresaMadre : Empresa
    {
        protected IList<Empresa> filiales = new List<Empresa>();
        protected IList<Empresa> startups = new List<Empresa>();

        public override bool agregaFilial(Empresa filial)
        {
            filiales.Add(filial);
            return true;
        }
        public override bool agregaStartup(Empresa startup)
        {
            startups.Add(startup);
            return true;
        }
        public override double calculaCosteMantenimiento()
        {
            double cout = 0.0;
            foreach (Empresa filial in filiales)
                cout = cout + filial.calculaCosteMantenimiento();
            foreach (Empresa startup in startups)
                cout = cout + startup.calculaCosteMantenimiento();
            return cout + nVehiculos * costeUnitarioVehiculo;
        }
    }
}

