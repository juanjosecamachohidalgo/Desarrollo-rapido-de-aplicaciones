using System;

namespace BuilderConsoleApp
{
    public class ClienteVehiculo
    {
        static void Main(string[] args)
        {
            ConstructorDocumentacionVehiculo constructor;
            Console.WriteLine("Desea generar " + "documentación HTML (1) , RTF (2) o PDF (3):");
            string seleccion = Console.ReadLine();
            if (seleccion == "1")
            {
                constructor = new ConstructorDocumentacionVehiculoHtml();
            }
            else if(seleccion == "2")
            {
                constructor = new ConstructorDocumentacionVehiculoRtf();
            }
            else
            {
                constructor = new ConstructorDocumentacionVehiculoPdf();
            }
            Vendedor vendedor = new Vendedor(constructor);
            Documentacion documentacion = vendedor.construye("Martín");
            documentacion.imprime();

            Console.ReadLine();
        }
    }
}
