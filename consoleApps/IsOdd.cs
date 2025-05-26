public class IsOdd
{
    public static void Odd()
    {
        Console.WriteLine("========== Is Odd or Not ??? ===========");
        Console.Write("Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number " + number + " is Even :(");
        }
        else
        {
            Console.WriteLine("The number " + number + " is Odd!!!");
        }
    }
}