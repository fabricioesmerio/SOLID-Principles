
namespace OCP
{
    public class CalculoImpostoPadrao : ICalculoImposto
    {
        public decimal CalcularImposto(decimal valor)
        {
            return valor * 0.1m; // 10% de imposto
        }
    }
}
