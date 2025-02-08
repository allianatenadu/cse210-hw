public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Exercise", "Focus on breathing in and out.") {}

    protected override void Run()
    {
        for (int i = 0; i < Duration / 6; i++)
        {
            Console.Write("Breathe in... ");
            ShowProgressBar(3);
            Console.Write("Breathe out... ");
            ShowProgressBar(3);
        }
    }
}
