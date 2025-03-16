public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public new string GetFullDetails()
    {
        return GetDetails() + $"\nEvent Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public new string GetShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {_title}\nDate: {_date}";
    }
}