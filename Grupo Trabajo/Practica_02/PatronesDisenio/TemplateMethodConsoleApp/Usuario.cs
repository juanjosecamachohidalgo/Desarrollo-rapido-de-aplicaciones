using System;

namespace TemplateMethodConsoleApp
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            Pedido pedidoEspa�a = new PedidoEspania();
            pedidoEspa�a.setImporteSinIVA(10000);
            pedidoEspa�a.calculaPrecioConIVA();
            pedidoEspa�a.visualiza();

            Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
            pedidoLuxemburgo.setImporteSinIVA(10000);
            pedidoLuxemburgo.calculaPrecioConIVA();
            pedidoLuxemburgo.visualiza();

            Console.ReadLine();
        }
    }
}
