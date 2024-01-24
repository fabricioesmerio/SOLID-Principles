
using SRP.Models;
using SRP.Repositories;

namespace SRP.Services
{
    public class CarrinhoService
    {
        private ServicoFiscal _servicoFiscal;
        private IRepositorio<Pedido> _repositorioPedido;

        public CarrinhoService(ServicoFiscal servicoFiscal, IRepositorio<Pedido> repositorioPedido)
        {
            _servicoFiscal = servicoFiscal;
            _repositorioPedido = repositorioPedido;
        }

        public void FinalizarCompra(List<ItemCarrinho> itensCarrinho)
        {
            // Lógica de finalização da compra
            var pedido = CriarPedido(itensCarrinho);
            CalcularTotal(pedido);
            SalvarPedido(pedido);
        }

        private Pedido CriarPedido(List<ItemCarrinho> itensCarrinho)
        {
            return new Pedido { Itens = itensCarrinho };
        }

        private void CalcularTotal(Pedido pedido)
        {
            // Lógica qualquer para cálculo do total
            pedido.Total = pedido.Itens.Sum(item => item.Produto.Preco * item.Quantidade);
            // Adiciona o imposto ao total
            pedido.Total += _servicoFiscal.CalcularImposto(pedido.Total);
        }

        private void SalvarPedido(Pedido pedido)
        {
            // Exemplo para persistir o pedido no banco de dados
            _repositorioPedido.Salvar(pedido);
        }
    }
}
