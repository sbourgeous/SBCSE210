public class Receptions : Event
{
    private string _rsvp;

    public Receptions(string title, string description, string date, string time, Address address, string rsvp)
        : base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public new string GetFullDetails()
    {
        return GetDetails() + $"\nEvent Type: Reception\nRSVP: {_rsvp}";
    }

    public new string GetShortDescription()
    {
        return $"Event Type: Reception\nTitle: {_title}\nDate: {_date}";
    }
}