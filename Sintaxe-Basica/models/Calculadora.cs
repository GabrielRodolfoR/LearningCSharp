namespace Calculator.models
{
    /// <summary>
    /// Calculadora para operações de matematica básica e ângulos
    /// </summary>
    public class Calculadora
    {
        // Matematica Básica
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void RaizQuadrada(int x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz de {x} = {raiz}");
        }

        // Calculo de Ângulos
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {seno}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosceno = Math.Cos(radiano);
            Console.WriteLine($"Cosceno de {angulo}º = {cosceno}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {tangente}");
        }
    }
}