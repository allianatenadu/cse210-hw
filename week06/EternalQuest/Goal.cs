public abstract class Goal
{
    // Private fields with public getters
    private string name;
    private string description;
    private int points;
    private bool isComplete;

    public string Name => name; // Public getter
    public string Description => description;
    public int Points => points;
    public bool IsComplete => isComplete;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.isComplete = false;
    }

    public abstract int RecordEvent(); // Polymorphism: Each goal type will implement this differently

    public virtual string GetStatus()
    {
        return isComplete ? "[X]" : "[ ]";
    }

    public abstract string SaveToFile();
}
