
namespace OCP
{
    public class CalculadoraImpostoFactory
    {
        public static CalculadoraImposto CriarCalculadoraImposto(TipoProduto tipoProduto)
        {
            switch (tipoProduto)
            {
                case TipoProduto.Padrao:
                    return new CalculadoraImposto(new CalculoImpostoPadrao());
                case TipoProduto.Importado:
                    return new CalculadoraImposto(new CalculoImpostoImportado());
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoProduto), "Tipo de produto não suportado");
            }
        }
    }
}
