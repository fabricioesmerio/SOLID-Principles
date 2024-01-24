
using SRP.Models;
using SRP.Repositories;
using SRP.Services;

var repositorioPedido = new RepositorioPedido();
var servicoFiscal = new ServicoFiscal();
var carrinhoService = new CarrinhoService(servicoFiscal, repositorioPedido);

var produto1 = new Produto { Nome = "Laptop", Preco = 1500 };
var produto2 = new Produto { Nome = "Câmera", Preco = 800 };
var itensCarrinho = new List<ItemCarrinho>
{
    new ItemCarrinho { Produto = produto1, Quantidade = 2 },
    new ItemCarrinho { Produto = produto2, Quantidade = 1 }
};

// Finalizando a compra
carrinhoService.FinalizarCompra(itensCarrinho);


