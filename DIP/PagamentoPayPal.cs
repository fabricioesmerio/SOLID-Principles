
namespace DIP
{
    public class PagamentoPayPal : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Foi processado um pagamento com PayPal no valor de {valor}.");
        }
    }
}
