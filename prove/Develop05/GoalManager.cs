public class GoalManager
{
    public List<Goal> Goals { get; set; } = new List<Goal>();
    public int Score { get; set; } = 0;

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Goals[goalIndex].RecordEvent();
            Score += Goals[goalIndex].Points;
            if (Goals[goalIndex] is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
            {
                Score += checklistGoal.BonusPoints;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nThe goals are:");
        foreach (var goal in Goals)
        {
            goal.Display();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYour score is: {Score}");
    }

    public void SaveGoals(string filename)
    {
        List<string> goalStrings = new List<string>();
        foreach (var goal in Goals)
        {
            goalStrings.Add(goal.GetStringRepresentation());
        }
        File.WriteAllLines(filename, goalStrings);
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] goalStrings = File.ReadAllLines(filename);
            Goals.Clear();
            Score = 0;
            foreach (var goalString in goalStrings)
            {
                string[] parts = goalString.Split(':');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        Goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])) { IsComplete = bool.Parse(parts[3]) });
                        if (bool.Parse(parts[3])) Score += int.Parse(parts[2]);
                        break;
                    case "EternalGoal":
                        Goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                        break;
                    case "ChecklistGoal":
                        Goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])) { CurrentCount = int.Parse(parts[5]), IsComplete = bool.Parse(parts[6]) });
                        if (bool.Parse(parts[6])) Score += int.Parse(parts[2]) + int.Parse(parts[4]);
                        else Score += int.Parse(parts[2]) * int.Parse(parts[5]);
                        break;
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}