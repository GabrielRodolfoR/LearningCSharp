using ExploreExample.models;

namespace ExemploAluno.models
{
    public class Alunos : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar() // sobrescreve o metodo Herdado
        {
            Console.WriteLine($"O aluno {Nome} de {Idade} anos, tirou {Nota}");
        }
    }
}