using System;

namespace FactoryMethodConsoleApp
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            Cliente cliente;
            cliente = new ClienteContado();
            cliente.nuevoPedido(2000.0);
            cliente.nuevoPedido(10000.0);
            cliente = new ClienteCredito();
            cliente.nuevoPedido(2000.0);
            cliente.nuevoPedido(10000.0);
            cliente = new ClienteTrueque();
            cliente.nuevoPedido(2000.0);
            cliente.nuevoPedido(10000.0);

            Console.ReadLine();
        }
    }
}
