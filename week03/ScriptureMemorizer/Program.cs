using System;

public class Program
{
    public static void Main(string[] args)
    {
        var reference = new Reference("Proverbs", 3, 5, 6);
        var scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding.");

        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input?.ToLower() == "quit") break;

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("All words are hidden. Program ending.");
    }
}
