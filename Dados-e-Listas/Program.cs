using ExploreExample.models;

public class Program
{
    public static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();

        p1.Nome = "Gabriel";
        p1.Idade = 20;

        p1.Apresentar();
    }
}