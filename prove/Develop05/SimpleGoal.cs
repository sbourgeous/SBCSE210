public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"[{(IsComplete ? "X" : " ")}] {Name}");
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name}:{Points}:{IsComplete}";
    }
}