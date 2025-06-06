using ExploreExample.models;
using Courses.models;

public class Program
{
    public static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Gabriel", "Rodolfo Rabello");
        Pessoa p2 = new Pessoa("Miguel", "Rodriguez");

        Cursos cursoIngles = new Cursos();
        cursoIngles.Nome = "Inglês";
        cursoIngles.Alunos = new List<Pessoa>();

        cursoIngles.AdicionarAluno(p1);
        cursoIngles.AdicionarAluno(p2);
        cursoIngles.ListarAlunos();

        /*
        Pessoa p1 = new Pessoa();

        p1.Nome = "Gabriel";
        p1.Sobrenome = "Rodolfo";
        p1.Idade = 18;

        p1.Apresentar();
        */
    }
}