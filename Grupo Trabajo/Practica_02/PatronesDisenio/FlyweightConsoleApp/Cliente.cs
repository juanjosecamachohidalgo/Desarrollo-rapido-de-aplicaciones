using System;

namespace FlyweightConsoleApp
{
    public class Client
    {
        static void Main(string[] args)
        {
            FabricaOpcion fabrica = new FabricaOpcion();
            VehiculoSolicitado vehiculo = new VehiculoSolicitado();
            vehiculo.agregaOpciones("air bag", 80, fabrica);
            vehiculo.agregaOpciones("direcci�n asistida", 90, fabrica);
            vehiculo.agregaOpciones("elevalunas el�ctricos", 85, fabrica);
            vehiculo.agregaOpciones("cambios autom�ticos", 75, fabrica);
            vehiculo.agregaOpciones("puertas autom�ticas", 105, fabrica);
            vehiculo.muestraOpciones();

            Console.ReadLine();
        }
    }
}

