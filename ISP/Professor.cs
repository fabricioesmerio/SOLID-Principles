
namespace ISP
{
    public class Professor : IProfessor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void DarAula()
        {
            Console.WriteLine($"O(a) professor(a) {Nome} está dando aula.");
        }

        public void AvaliarAluno()
        {
            Console.WriteLine($"O(a) professor(a) {Nome} está avaliando o aluno.");
        }
    }
}
