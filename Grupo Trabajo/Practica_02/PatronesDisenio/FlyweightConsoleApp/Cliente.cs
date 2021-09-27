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
            vehiculo.agregaOpciones("dirección asistida", 90, fabrica);
            vehiculo.agregaOpciones("elevalunas eléctricos", 85, fabrica);
            vehiculo.agregaOpciones("cambios automáticos", 75, fabrica);
            vehiculo.agregaOpciones("puertas automáticas", 105, fabrica);
            vehiculo.muestraOpciones();

            Console.ReadLine();
        }
    }
}

