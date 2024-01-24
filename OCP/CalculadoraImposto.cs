
namespace OCP
{
    public class CalculadoraImposto
    {
        private readonly ICalculoImposto _calculoImposto;

        public CalculadoraImposto(ICalculoImposto calculoImposto)
        {
            _calculoImposto = calculoImposto;
        }

        public decimal CalcularImpostoParaProduto(decimal valorProduto)
        {
            return _calculoImposto.CalcularImposto(valorProduto);
        }
    }
}
