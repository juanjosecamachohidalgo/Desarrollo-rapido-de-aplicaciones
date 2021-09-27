using System;

namespace TemplateMethodConsoleApp
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            Pedido pedidoEspaña = new PedidoEspania();
            pedidoEspaña.setImporteSinIVA(10000);
            pedidoEspaña.calculaPrecioConIVA();
            pedidoEspaña.visualiza();

            Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
            pedidoLuxemburgo.setImporteSinIVA(10000);
            pedidoLuxemburgo.calculaPrecioConIVA();
            pedidoLuxemburgo.visualiza();

            Console.ReadLine();
        }
    }
}
