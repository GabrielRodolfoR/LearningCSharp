public class AboutMe
{
    public static void Create()
    {
        Console.WriteLine("========== Login ===========");

        // Console Input
        Console.Write("\nName: ");
        string name = Console.ReadLine()!;

        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Height: ");
        double height = Convert.ToDouble(Console.ReadLine());


        // Nice to meet you!!
        Console.WriteLine("\n========== About Me ===========");
        Console.WriteLine("My name is: " + name + ", I have " + age + " years old and I'm " + height + "m height!");
        Console.WriteLine("================================\n");
    }
}