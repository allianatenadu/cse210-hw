public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Exercise", "List as many responses as possible.") {}

    protected override void Run()
    {
        Console.WriteLine("Think of as many items as possible...");
        ShowProgressBar(3);
        Console.WriteLine("Start listing:");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
    }
}