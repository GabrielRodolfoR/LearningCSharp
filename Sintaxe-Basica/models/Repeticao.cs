namespace Lacos.models
{
    /// <summary>
    /// Tabuada representada em diferentes estruturas de laços de repetição
    /// </summary>
    public class Repeticao()
    {
        public void TabuadaFor()
        {
            int numero = 5;

            Console.WriteLine($"========== Tabuada do {numero} ==========");
            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }

        public void TabuadaWhile()
        {
            int numero = 5;
            byte contador = 1;

            while (contador <= 10)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador++;
            }
        }

        public void SomaDoWhile()
        {
            int soma = 0, numero = 0;
            do
            {
                Console.Write("Número (para sair, digite 0): ");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;
            } while (numero != 0);

            Console.WriteLine($"Total: {soma}");
        }

    }
}