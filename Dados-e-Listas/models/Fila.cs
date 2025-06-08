namespace NovaFila.models
{
    public class Fila
    {
        public void NewFila()
        {
            Queue<int> fila = new Queue<int>();

            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(6);
            fila.Enqueue(8);

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo: {fila.Dequeue()}"); // sempre remove o primeiro elemento

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }
        }

        public void Pilha()
        {
            Stack<int> pilha = new Stack<int>();

            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);
            pilha.Push(10);

            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo: {pilha.Pop()}"); // remove sempre o ultimo elemento

            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }
        }

        public void Dicionario()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SC", "Santa Catarina");
            estados.Add("PR", "Paraná");
            estados.Add("RS", "Rio Grande do Sul");

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            estados.Remove("PR"); // Exclui pela Chave Primária
            estados["RS"] = "Valor Alterado"; // Pode ser modificado

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }
        }
    }
}