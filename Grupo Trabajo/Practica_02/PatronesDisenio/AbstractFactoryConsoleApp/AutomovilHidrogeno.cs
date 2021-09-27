using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsoleApp
{
    class AutomovilHidrogeno : Automovil
    {
        public AutomovilHidrogeno(string modelo, string
           color, int potencia, double espacio)
           : base(modelo,
               color, potencia, espacio)
        { }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine(
                "Automóvil de hidrogeno de modelo: " + modelo +
                " de color: " + color + " de potencia: " +
                potencia + " de espacio: " + espacio);
        }
    }
}
