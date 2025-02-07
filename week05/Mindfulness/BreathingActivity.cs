class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Exercise", "Focus on your breathing to relax.") { }

    protected override void PerformActivity()
    {
        for (int i = 0; i < Duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
        }
    }
}
