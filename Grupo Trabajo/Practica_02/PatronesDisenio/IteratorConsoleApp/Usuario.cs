using System;

namespace IteratorConsoleApp
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            CatalogoVehiculo catalogo = new CatalogoVehiculo();
            IteradorVehiculo iterador = catalogo.busqueda("econůmico");
            Vehiculo vehiculo;
            iterador.inicio();
            vehiculo = iterador.item();
            while (vehiculo != null)
            {
                vehiculo.visualiza();
                iterador.siguiente();
                vehiculo = iterador.item();
            }

            Console.ReadLine();
        }
    }
}
