public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }

    public string GetFullDetails()
    {
        return GetDetails();
    }

    public string GetShortDescription()
    {
        return $"Event Type: General\nTitle: {_title}\nDate: {_date}";
    }
}