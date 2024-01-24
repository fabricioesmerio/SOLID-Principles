
namespace OCP
{
    public class CalculoImpostoImportado : ICalculoImposto
    {
        public decimal CalcularImposto(decimal valor)
        {
            return valor * 0.2m; // 20% de imposto para este caso que são produtos importados
        }
    }
}
