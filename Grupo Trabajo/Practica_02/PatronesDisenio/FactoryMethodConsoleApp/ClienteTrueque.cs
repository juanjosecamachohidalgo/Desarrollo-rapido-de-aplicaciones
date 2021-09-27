using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodConsoleApp
{
    class ClienteTrueque : Cliente
    {
        protected override Pedido creaPedido(double importe)
        {
            return new PedidoTrueque(importe);
        }
    }
}
