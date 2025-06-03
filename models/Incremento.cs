namespace Incrementar.models
{
    public class Incremento
    {
        public void Sucessor()
        {
            Console.Write("Número: ");
            int x = Convert.ToInt32(Console.ReadLine());
            x++;

            Console.WriteLine($"O sucessor é {x}");
        }

        public void Antecessor()
        {
            Console.Write("Número: ");
            int y = Convert.ToInt32(Console.ReadLine());
            y--;

            Console.WriteLine($"O antecessor é {y}");
        }
    }
}