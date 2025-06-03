using Fundamentos.Models;
using Operators.models;
using Calculator.models;
using Incrementar.models;
using Lacos.models;
using CadastroClientes.models;

public class Program
{
    public static void Main(string[] args)
    {
        Menu clientes = new Menu();
        clientes.MenuInterativo();

        /*
        Repeticao rep = new Repeticao();
        rep.SomaDoWhile();

        /*
        rep.TabuadaFor();

        /*
        Calculadora calc = new Calculadora();

        /*
        calc.Somar(10, 5);
        calc.Subtrair(20, 2);
        calc.Multiplicar(9, 7);
        calc.Dividir(3, 1);
        calc.Potencia(3, 3);
        calc.RaizQuadrada(4);
        calc.Seno(60);
        calc.Coseno(60);
        calc.Tangente(45);

        /*
        Incremento inc = new Incremento();

        /*
        inc.Sucessor();
        inc.Antecessor();

        /*
        Operadores operador1 = new Operadores();
        operador1.Atribuicao();

        /*
        Pessoa pessoa1 = new Pessoa();

        /*
        pessoa1.Name = "Gabriel";
        pessoa1.Age = 18;
        pessoa1.Apresentar();
        */
    }
}