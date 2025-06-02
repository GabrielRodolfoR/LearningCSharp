namespace Fundamentos.Models
{
    public class Pessoa
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Name}, tenho {Age} anos");
        }
    }
}