namespace LeitorArquivos.models
{
    public class Leitor
    {
        public void LeitorDeArquivos()
        {
            try
            {
                string[] linhas = File.ReadAllLines("Files/arquivoLeitura.txt");

                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error!!! Arquivo não encontrado {ex.Message}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error!!! Exceção Genérica {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Fim das verificações!");
            }
        }
    }
}