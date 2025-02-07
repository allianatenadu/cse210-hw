class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time you showed great courage.",
        "Remember a moment when you helped someone in need.",
        "Reflect on an experience where you overcame a challenge."
    };

    public ReflectionActivity() : base("Reflection Exercise", "Think about meaningful moments in your life.") { }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        ShowSpinner(Duration);
    }
}