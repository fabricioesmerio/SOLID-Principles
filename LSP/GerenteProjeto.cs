
namespace LSP
{
    public class GerenteProjeto : Funcionario, IHabilidadesEspeciais
    {
        public void RealizarHabilidadeEspecial()
        {
            Console.WriteLine($"{Nome} está realizando uma habilidade especial de gerenciamento.");
        }

        public override void RealizarTarefa()
        {
            Console.WriteLine($"{Nome} está gerenciando um projeto.");
        }
    }
}
