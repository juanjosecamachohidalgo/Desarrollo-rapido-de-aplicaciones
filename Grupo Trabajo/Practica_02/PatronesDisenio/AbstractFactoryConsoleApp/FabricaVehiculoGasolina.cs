using System;

namespace AbstractFactoryConsoleApp
{

    public class FabricaVehiculoGasolina : FabricaVehiculo
    {
        public Automovil creaAutomovil(string modelo, string color, int potencia, double espacio)
        {
            return new AutomovilGasolina(modelo, color, potencia, espacio);
        }

        public Scooter creaScooter(string modelo, string color, int potencia)
        {
            return new ScooterGasolina(modelo, color, potencia);
        }
    }
}
