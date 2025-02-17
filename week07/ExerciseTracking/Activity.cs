public abstract class Activity
{
    public DateTime Date { get; set; }
    public int Duration { get; set; }  // Duration in minutes
    
    public abstract double GetDistance();  // Method to calculate distance
    public abstract double GetSpeed();     // Method to calculate speed
    public abstract double GetPace();      // Method to calculate pace
    
    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Duration} min): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
