class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "List people who have inspired you.",
        "List things you are grateful for.",
        "List acts of kindness you have witnessed."
    };

    public ListingActivity() : base("Listing Exercise", "List things that bring you joy and appreciation.") { }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        Console.WriteLine("Start listing... (Press Enter after each item, type 'done' to finish)");
        List<string> responses = new List<string>();
        string input;
        while ((input = Console.ReadLine().ToLower()) != "done")
        {
            responses.Add(input);
        }
        Console.WriteLine($"You listed {responses.Count} items!");
    }
}
