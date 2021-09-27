using System;

namespace PrototypeConsoleApp
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
            documentacionEnBlanco.incluye(new OrdenDePedido());
            documentacionEnBlanco.incluye(new CertificadoCesion());
            documentacionEnBlanco.incluye(new SolicitudMatriculacion());
            // creaci�n de documentaci�n nueva para dos clientes
            DocumentacionCliente documentacionCliente1 = new DocumentacionCliente("Mart�n");
            DocumentacionCliente documentacionCliente2 = new DocumentacionCliente("Sim�n");
            DocumentacionCliente documentacionCliente3 = new DocumentacionCliente("Juan");
            documentacionCliente1.visualiza();
            documentacionCliente2.visualiza();
            documentacionCliente3.visualiza();

            Console.ReadLine();
        }
    }
}

