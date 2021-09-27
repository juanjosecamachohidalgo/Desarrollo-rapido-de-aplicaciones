using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsoleApp
{
    class FabricaVehiculoHidrogeno : FabricaVehiculo
    {
        public Automovil creaAutomovil(string modelo, string color, int potencia, double espacio)
        {
            return new AutomovilHidrogeno(modelo, color, potencia, espacio);
        }

        public Scooter creaScooter(string modelo, string color, int potencia)
        {
            return new ScooterHidrogeno(modelo, color, potencia);
        }
    }
}
