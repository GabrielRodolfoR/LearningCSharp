public class RelationalOperators
{
    public static void Relational()
    {
        string result;

        Console.WriteLine("========== Relational Operators ==========");
        Console.Write("Number 1: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Number 2: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == y)
        {
            result = "X equals Y";
        }
        else
        {
            result = "X is NOT equals Y";
        }

        Console.WriteLine("\nEqualsf (==): " + result);
    }
}