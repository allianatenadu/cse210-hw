using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        string filename = "goals.txt";

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals & Score");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter Goal Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Description:");
                string desc = Console.ReadLine();
                Console.WriteLine("Enter Points:");
                int points = int.Parse(Console.ReadLine());

                Console.WriteLine("Select Goal Type: 1. Simple 2. Eternal 3. Checklist");
                string type = Console.ReadLine();

                if (type == "1") manager.CreateGoal(new SimpleGoal(name, desc, points));
                else if (type == "2") manager.CreateGoal(new EternalGoal(name, desc, points));
                else if (type == "3")
                {
                    Console.WriteLine("Enter Target Count:");
                    int target = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Bonus Points:");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.CreateGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == "2") manager.RecordEvent(0);
            else if (choice == "3") manager.DisplayGoals();
            else if (choice == "4") manager.SaveGoals(filename);
            else if (choice == "5") manager.LoadGoals(filename);
            else if (choice == "6") break;
        }
    }
}
