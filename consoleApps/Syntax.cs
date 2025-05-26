public class Syntax
{
    public static void Start()
    {
        // const nunca muda seu valor ou tipo atribuido
        const int constant = 20;
        Console.WriteLine(constant);

        // var determina automaticamente o tipo, mas apenas na 1ª vez
        var variable = "Algo";
        Console.WriteLine(variable);

        // dynamic pode mudar o tipo sempre que quiser
        dynamic dynamic = 20;
        Console.WriteLine(dynamic);

        dynamic = "String";
        Console.WriteLine(dynamic);
    }
}