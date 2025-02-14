using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;

    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            totalScore += goals[index].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name}");
        }
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(totalScore);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SaveToFile());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            totalScore = int.Parse(lines[0]);
            goals.Clear();

            foreach (string line in lines[1..])
            {
                string[] parts = line.Split(":");
                string type = parts[0];
                string[] data = parts[1].Split(",");

                if (type == "SimpleGoal")
                {
                    goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                }
                else if (type == "EternalGoal")
                {
                    goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                }
                else if (type == "ChecklistGoal")
                {
                    goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])));
                }
            }
        }
    }
}
