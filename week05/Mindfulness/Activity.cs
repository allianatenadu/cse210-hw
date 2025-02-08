public abstract class Activity
{
    private string name;
    private string description;
    private int duration;

    public string Name { get => name; }
    public string Description { get => description; }
    public int Duration { get => duration; set => duration = value; }

    protected Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"{Name}\n{Description}\n");
        Console.Write("Enter duration (seconds): ");
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Invalid input. Enter a positive number: ");
        }
        Console.WriteLine("\nGet ready...");
        ShowProgressBar(3);
        Run();
        Console.WriteLine("\nWell done! Returning to menu...");
        ShowProgressBar(2);
    }

    protected abstract void Run();

    protected void ShowProgressBar(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("[===]");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}