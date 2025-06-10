namespace ExploreExample.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade { get; set; }

        public virtual void Apresentar() // Permite ser reescrito quando herdado
        {
            Console.WriteLine($"{NomeCompleto}, idade: {Idade}");
        }
    }
}