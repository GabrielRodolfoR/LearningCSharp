public class Calculator
{
    public static void Equals()
    {
        Console.WriteLine("Number 1: ");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Number 2: ");
        decimal num2 = Convert.ToDecimal(Console.ReadLine());

        decimal add = num1 + num2;
        decimal sub = num1 - num2;
        decimal mult = num1 * num2;
        decimal div = num1 / num2;
        decimal module = num1 % num2;

        Console.WriteLine("========== Results ===========");
        Console.WriteLine("Add: " + add);
        Console.WriteLine("Sub: " + sub);
        Console.WriteLine("Mult: " + mult);
        Console.WriteLine("Div: " + div);
        Console.WriteLine("Module: " + module);
    }
}