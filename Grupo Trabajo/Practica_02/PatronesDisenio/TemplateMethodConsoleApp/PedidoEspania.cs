namespace TemplateMethodConsoleApp
{
    public class PedidoEspania : Pedido
    {
        protected override void calculaIVA()
        {
            importeIVA = importeSinIVA * 0.21;
        }
    }
}
