using System;

namespace DecoratorConsoleApp
{
    public class VistaVehiculo : ComponenteGraficoVehiculo
    {
        public void visualiza()
        {
            Console.WriteLine("Visualizaci�n del veh�culo");
        }
    }
}

