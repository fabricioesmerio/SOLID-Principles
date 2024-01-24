
namespace ISP
{
    public class Aluno : IAluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Matricular()
        {
            Console.WriteLine($"O(a) aluno(a) {Nome} está matriculado(a).");
        }

        public void Estudar()
        {
            Console.WriteLine($"O(a) aluno(a) {Nome} está estudando.");
        }
    }
}
