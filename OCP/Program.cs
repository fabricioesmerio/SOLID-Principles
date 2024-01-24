using OCP;

decimal valorProduto = 200;

// calculadora de imposto: produto padrão
var calculadoraPadrao = CalculadoraImpostoFactory.CriarCalculadoraImposto(TipoProduto.Padrao);
decimal impostoPadrao = calculadoraPadrao.CalcularImpostoParaProduto(valorProduto);
Console.WriteLine($"Imposto para produto padrão: {impostoPadrao:C}");

// calculadora de imposto:  produto importado
var calculadoraImportado = CalculadoraImpostoFactory.CriarCalculadoraImposto(TipoProduto.Importado);
decimal impostoImportado = calculadoraImportado.CalcularImpostoParaProduto(valorProduto);
Console.WriteLine($"Imposto para produto importado: {impostoImportado:C}");
