using System;

namespace ProxyConsoleApp
{
    public class VistaVehiculo
    {
        static void Main(string[] args)
        {
            Animacion animacion = new AnimacionProxy();
            animacion.dibuja();
            animacion.clic();
            animacion.dibuja();

            Console.ReadLine();
        }
    }
}

