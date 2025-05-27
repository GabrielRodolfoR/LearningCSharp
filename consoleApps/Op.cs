public class Op
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

    public static void Relational()
    {
        string result;
        string greater;

        Console.WriteLine("========== Relational Operators ==========");
        Console.Write("X value: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Y value: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == y)
        {
            result = "X equals Y";
        }
        else // if (x != y)
        {
            result = "X is NOT equals Y";

            if (x > y)
            {
                greater = "X is greater than Y";
            }
            else // if (x < y)
            {
                greater = "Y is greater than X";
            }

            Console.WriteLine("\nGreat (> or <): " + greater);
        }

        Console.WriteLine("\nEquals (==): " + result);
    }
}