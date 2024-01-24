
namespace LSP
{
    public class Desenvolvedor : Funcionario, IHabilidadesEspeciais
    {
        public void RealizarHabilidadeEspecial()
        {
            Console.WriteLine($"{Nome} está fazendo café.");
        }

        public override void RealizarTarefa()
        {
            Console.WriteLine($"{Nome} está programando.");
        }
    }
}
