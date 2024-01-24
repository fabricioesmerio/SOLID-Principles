
namespace SRP.Models
{
    public class Pedido
    {
        public List<ItemCarrinho> Itens { get; set; }
        public decimal Total { get; set; }
    }
}
