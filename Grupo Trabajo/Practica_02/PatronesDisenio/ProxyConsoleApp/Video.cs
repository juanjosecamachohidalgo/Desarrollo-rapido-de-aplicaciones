using System;

namespace ProxyConsoleApp
{
    public class Video : Animacion
    {
        public void clic() { }

        public void dibuja()
        {
            Console.WriteLine("Mostrar el v?deo");
        }

        public void carga()
        {
            Console.WriteLine("Cargar el v?deo");
        }

        public void reproduce()
        {
            Console.WriteLine("Reproducir el v?deo");
        }
    }
}
