using System;

namespace AbstractFactoryConsoleApp
{

    public class ScooterGasolina : Scooter
    {
        public ScooterGasolina(string modelo, string color, int potencia) : base(modelo, color, potencia) { }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine("Scooter gasolina de modelo: " +
            modelo + " de color: " + color + " de potencia: " + potencia);
        }
    }
}
