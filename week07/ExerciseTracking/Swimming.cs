public class Swimming : Activity
{
    public int Laps { get; set; }
    
    public override double GetDistance()
    {
        return (Laps * 50.0) / 1000.0 * 0.62;  // Distance in miles
    }
    
    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60;  // Speed in miles per hour
    }
    
    public override double GetPace()
    {
        return Duration / GetDistance();  // Pace in minutes per mile
    }
}
