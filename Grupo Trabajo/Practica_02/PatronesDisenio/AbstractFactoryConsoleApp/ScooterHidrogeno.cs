using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsoleApp
{
    public class ScooterHidrogeno : Scooter
    {
        public ScooterHidrogeno(string modelo, string color, int potencia) : base(modelo, color, potencia) { }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine("Scooter hidrogeno de modelo: " +
            modelo + " de color: " + color + " de potencia: " + potencia);
        }
    }
}
