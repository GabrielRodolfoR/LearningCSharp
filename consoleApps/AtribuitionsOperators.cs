public class AtribuitionsOperator
{
    public static void Atribuition()
    {
        Console.WriteLine("========== Atribuition Operators ===========");
        int x = 10;
        Console.WriteLine("\nInitial Value of X: " + x);

        x = 20;
        Console.WriteLine("\nSimple Atribuition (=)");
        Console.WriteLine("New X value: " + x);

        x++;
        Console.WriteLine("\nIncremental Atribuition (++)");
        Console.WriteLine("New X value: " + x);

        x += 10;
        Console.WriteLine("\nIncremental Atribuition (+=)");
        Console.WriteLine("New X value: " + x);

        x -= 11;
        Console.WriteLine("\nIncremental Atribuition (-=)");
        Console.WriteLine("New X value: " + x);

        x *= 2;
        Console.WriteLine("\nIncremental Atribuition (*=)");
        Console.WriteLine("New X value: " + x);

        x /= 2;
        Console.WriteLine("\nIncremental Atribuition (/=)");
        Console.WriteLine("New X value: " + x);
    }
}