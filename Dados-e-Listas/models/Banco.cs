using System.Globalization;

namespace Monetario.models
{
    public class Banco
    {
        public void ValorMonetario()
        {
            // CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // Formata os valores para a cultura escolhida
            decimal valorMonetario = 1582.40M;

            Console.WriteLine($"{valorMonetario:C}"); // Formata o valor com base na cultura local
            Console.WriteLine(valorMonetario.ToString("C8")); // Mostra X casas decimais

            double porcentagem = .3145;
            Console.WriteLine(porcentagem.ToString("P")); // Formata para porcentagem

            int numero = 123456;
            Console.WriteLine(numero.ToString("##-##-##")); // formata da forma em que esta escrito

            DateTime data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.ToString("dd/MM/yyyy"));
        }
    }
}