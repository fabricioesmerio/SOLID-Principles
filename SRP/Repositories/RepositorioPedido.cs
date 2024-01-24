
using SRP.Models;

namespace SRP.Repositories
{
    public class RepositorioPedido : IRepositorio<Pedido>
    {
        public void Salvar(Pedido pedido)
        {
            Console.WriteLine($"Salvando pedido no banco de dados. Total: {pedido.Total}");
        }
    }
}
