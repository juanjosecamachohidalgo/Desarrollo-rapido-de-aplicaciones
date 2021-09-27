using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodConsoleApp
{
    class PedidoTrueque : Pedido
    {
        public PedidoTrueque(double importe) : base(importe) { }

        public override void paga()
        {
            Console.WriteLine("El pago del pedido a trueque de: " + importe + " bitcoins se ha realizado.");
        }

        public override bool valida()
        {
            return true;
        }
    }
}
