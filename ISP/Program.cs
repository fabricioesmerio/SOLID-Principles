using ISP;

Escola minhaEscola = new Escola();

IAluno aluno1 = new Aluno { Nome = "Joãozinho", Idade = 10 };
IProfessor professor1 = new Professor { Nome = "Mariazinha", Idade = 35 };

minhaEscola.AdicionarAluno(aluno1);
minhaEscola.AdicionarProfessor(professor1);

aluno1.Matricular();
aluno1.Estudar();

professor1.DarAula();
professor1.AvaliarAluno();