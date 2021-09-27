using System;

namespace PrototypeConsoleApp
{
    public class OrdenDePedido : Documento
    {
        public override void visualiza()
        {
            Console.WriteLine("Muestra la orden de pedido: " + contenido);
        }

        public override void imprime()
        {
            Console.WriteLine("Imprime la orden de pedido: " + contenido);
        }
    }
}

