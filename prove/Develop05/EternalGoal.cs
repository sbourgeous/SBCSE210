public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never complete
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {Name}");
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name}:{Points}";
    }
}