
namespace LSP
{
    public class SistemaRecursosHumanos
    {
        public static void RealizarTarefaEImprimir(Funcionario funcionario)
        {
            funcionario.RealizarTarefa();
        }

        public static void RealizarHabilidadeEspecialEImprimir(IHabilidadesEspeciais habilidadesEspeciais)
        {
            habilidadesEspeciais.RealizarHabilidadeEspecial();
        }
    }
}
