using System.Text; // Bitte nicht löschen!

namespace git.test;

public class Program
{
    public static void Main(string[] args)
    {
        // Behebung des Problems der Eingabe von z.B. Umlauten - Bitte nicht löschen!
        Console.InputEncoding = Encoding.Unicode;

        // Und ab hier kommt Ihr eigener Quellcode...
        Console.WriteLine("Hallo, Wildau!");
        System.Console.WriteLine("erster test");
    }
}