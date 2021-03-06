using System;

namespace AbstractFactoryConsoleApp
{

    public class Catalogo
    {
        public static int nAutos = 3;
        public static int nScooters = 2;

        static void Main(string[] args)
        {
            FabricaVehiculo fabrica;
            Automovil[] autos = new Automovil[nAutos];
            Scooter[] scooters = new Scooter[nScooters];
            Console.WriteLine("Desea utilizar " + "veh?culos el?ctricos (1), veh?culos de hidrogeno (2) o a gasolina (3):");
            string eleccion = Console.ReadLine();
            if (eleccion == "1")
            {
                fabrica = new FabricaVehiculoElectricidad();
            }
            else if(eleccion == "2")
            {
                fabrica = new FabricaVehiculoHidrogeno();
            }
            else
            {
                fabrica = new FabricaVehiculoGasolina();
            }
            for (int index = 0; index < nAutos; index++)
                autos[index] = fabrica.creaAutomovil("est?ndar", "amarillo", 6 + index, 3.2);
            for (int index = 0; index < nScooters; index++)
                scooters[index] = fabrica.creaScooter("cl?sico", "rojo", 2 + index);
            foreach (Automovil auto in autos)
                auto.mostrarCaracteristicas();
            foreach (Scooter scooter in scooters)
                scooter.mostrarCaracteristicas();

            Console.ReadLine();
        }

    }
}
