public class ChecklistGoal : Goal
{
    public int RequiredCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int requiredCount, int bonusPoints) : base(name, points)
    {
        RequiredCount = requiredCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= RequiredCount)
        {
            IsComplete = true;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"[{(IsComplete ? "X" : " ")}] {Name} (Completed {CurrentCount}/{RequiredCount} times)");
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name}:{Points}:{RequiredCount}:{BonusPoints}:{CurrentCount}:{IsComplete}";
    }
}