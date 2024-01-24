using LSP;


Desenvolvedor desenvolvedor = new Desenvolvedor { Nome = "Fabricio" };
SistemaRecursosHumanos.RealizarTarefaEImprimir(desenvolvedor);
SistemaRecursosHumanos.RealizarHabilidadeEspecialEImprimir(desenvolvedor);

GerenteProjeto gerenteProjeto = new GerenteProjeto { Nome = "Alguém" };
SistemaRecursosHumanos.RealizarTarefaEImprimir(gerenteProjeto);
SistemaRecursosHumanos.RealizarHabilidadeEspecialEImprimir(gerenteProjeto);
