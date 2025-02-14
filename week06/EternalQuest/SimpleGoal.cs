public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string SaveToFile()
    {
        return $"SimpleGoal:{Name},{Description},{Points}";
    }
}