public class OutdoorGatherings : Event
{
    private string _weatherForecast;

    public OutdoorGatherings(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public new string GetFullDetails()
    {
        return GetDetails() + $"\nEvent Type: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public new string GetShortDescription()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {_title}\nDate: {_date}";
    }
}