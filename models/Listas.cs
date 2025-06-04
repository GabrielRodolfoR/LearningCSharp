namespace ArrayListas.models
{
    /// <summary>
    /// Maneiras diferentes de percorrer uma lista
    /// </summary>
    public class Listas
    {
        public void ArrayInteiro()
        {
            int[] arrayInteiros = new int[3];

            Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // Para mudar o tamanho do array

            arrayInteiros[0] = 72;
            arrayInteiros[1] = 10;
            arrayInteiros[2] = 69;

            for (int contador = 0; contador < arrayInteiros.Length; contador++)
            {
                Console.WriteLine($"Nº{contador} | {arrayInteiros[contador]}");
            }
        }

        public void ArrayForEach()
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 72;
            arrayInteiros[1] = 10;
            arrayInteiros[2] = 69;

            foreach (int valor in arrayInteiros)
            {
                Console.WriteLine($"{valor}");
            }
        }

        public void ListaForEach()
        {
            List<string> listaString = new List<string>();

            listaString.Add("SC");
            listaString.Add("RS");
            listaString.Add("PR");

            foreach(string item in listaString)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}