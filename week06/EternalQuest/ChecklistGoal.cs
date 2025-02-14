public class ChecklistGoal : Goal
{
    private int target;
    private int progress;

    public ChecklistGoal(string name, string description, int points, int target, int progress) 
        : base(name, description, points)
    {
        this.target = target;
        this.progress = progress;
    }

    public override int RecordEvent()
    {
        if (progress < target)
        {
            progress++;
            return Points;
        }
        return 0;
    }

    public override string SaveToFile()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{target},{progress}";
    }
}
