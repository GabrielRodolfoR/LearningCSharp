using System.IO;
using System.IO.Enumeration;

public class FilesCreator
{
    public static void FileManager()
    {
        Console.Write("File Name: ");
        string fileName = Console.ReadLine()!;

        Console.Write("Message: ");
        string message = Console.ReadLine()!;

        System.IO.File.WriteAllText(fileName, message);
        Console.WriteLine("File Successfull Created, please check 'bin/Debug' folder");
    }
}