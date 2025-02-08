public class ReflectionActivity : Activity
{
    private string[] prompts = { "Think of a time you overcame a challenge.", "Recall a happy memory.", "Remember a time you helped someone." };

    public ReflectionActivity() : base("Reflection Exercise", "Reflect on positive experiences.") {}

    protected override void Run()
    {
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        ShowProgressBar(Duration);
    }
}