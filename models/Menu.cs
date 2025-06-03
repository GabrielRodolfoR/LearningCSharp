namespace CadastroClientes.models
{
    public class Menu
    {
        public void MenuInterativo()
        {
            while (true)
            {
                Console.WriteLine(
                    "Digite a opção:" +
                    "\n1 - Castrar Cliente" +
                    "\n2 - Buscar Cliente" +
                    "\n3 - Apagar Cliente" +
                    "\n4 - Encerrar");
                string opcao = Console.ReadLine()!;

                if (opcao == "1")
                {
                    Console.WriteLine("========== Cadastrar novo Cliente ==========");
                }

                else if (opcao == "2")
                {
                    Console.WriteLine("========== Buscar Cliente ==========");
                }

                else if (opcao == "3")
                {
                    Console.WriteLine("========== Buscar Cliente ==========");
                }

                else if (opcao == "4")
                {
                    Console.WriteLine("========== Encerrando o Programa... ==========");
                    break;
                }

                else
                {
                    Console.WriteLine("Opção Inválida!");
                }
            }
        }
    }
}