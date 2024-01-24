
namespace ISP
{
    public class Escola
    {
        public List<IAluno> Alunos { get; set; }
        public List<IProfessor> Professores { get; set; }
        
        public Escola()
        {
            Alunos = new List<IAluno>();
            Professores = new List<IProfessor>();
        }

        public void AdicionarAluno(IAluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void AdicionarProfessor(IProfessor professor)
        {
            Professores.Add(professor);
        }


    }
}
