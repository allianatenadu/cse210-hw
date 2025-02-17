using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = DateTime.Now, Duration = 30, Distance = 3.0 },
            new Cycling { Date = DateTime.Now, Duration = 45, Speed = 12.0 },
            new Swimming { Date = DateTime.Now, Duration = 60, Laps = 30 }
        };
        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
