
namespace DIP
{
    public class PagamentoCartaoCredito : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Foi processado um pagamento com cartão de crédito no valor de {valor}.");
        }
    }
}
