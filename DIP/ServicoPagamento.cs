
namespace DIP
{
    public class ServicoPagamento
    {
        private readonly IPagamento _metodoPagamento;

        public ServicoPagamento(IPagamento metodoPagamento)
        {
            _metodoPagamento = metodoPagamento;
        }

        public void RealizarPagamento(decimal valor)
        {
            _metodoPagamento.ProcessarPagamento(valor);
        }
    }
}
