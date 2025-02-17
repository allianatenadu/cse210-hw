public class Cycling : Activity
{
    public double Speed { get; set; }
    
    public override double GetDistance()
    {
        return (Speed * Duration) / 60;  // Distance in miles
    }
    
    public override double GetSpeed()
    {
        return Speed;  // Already stored
    }
    
    public override double GetPace()
    {
        return 60 / Speed;  // Pace in minutes per mile
    }
}
